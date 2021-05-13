/*  
    The MIT License (MIT)

    Copyright (c) 2019 Alexander Schmid

    Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBS.WebSocket.NET;
using OBS.WebSocket.NET.Types;
using tailobs.Earthquake;
using WebSocket4Net.Protocol;

namespace tailobs
{
    public partial class tailobs : Form
    {
        protected ObsWebSocket _obs;
        protected bool IsRecording;

        protected int LeftStoppingTimeSec = 0;

        public tailobs()
        {
            InitializeComponent();
            _obs = new ObsWebSocket();

            //initialize
            UrlTextbox.Text = Properties.Settings.Default.obsurl;
            PasswordTextbox.Text = Properties.Settings.Default.obspassword;
            ExtensionTimeTextbox.Text = Properties.Settings.Default.RecTime.ToString();
            AddExtensionTimeTextbox.Text = Properties.Settings.Default.AddTime.ToString();

            RefreshControlsStatus();
            ReloadAddTime();

            _obs.RecordingStateChanged += onRecordingStateChange;
            _obs.StreamingStateChanged += onStreamingStateChange;
            _obs.StreamStatus += onStreamData;

        }

        void RefreshControlsStatus()
        {
            recordbtn.Enabled = _obs.IsConnected ? true : false;
            streamingbtn.Enabled = _obs.IsConnected ? true : false;
            ExtensionTimeTextbox.Enabled = _obs.IsConnected ? true : false;
            AddExtensionTimeTextbox.Enabled = _obs.IsConnected ? true : false;
        }

        void ReloadAddTime()
        {
            //AddLeftTime
            LeftStoppingTimeSec = Properties.Settings.Default.RecTime * 60;
            RecordLimitTimeLabel.Text = $"{LeftStoppingTimeSec}秒/{LeftStoppingTimeSec / 60}分";
        }

        void ResetStreamingStateText()
        {
            BeginInvoke((MethodInvoker)delegate {
                txtStreamTime.Text = "0";
                txtKbitsSec.Text = "0";
                txtBytesSec.Text = "0";
                txtFramerate.Text = "0";
                txtDroppedFrames.Text = "0";
                txtTotalFrames.Text = "0";
            });
        }

        private void ConnectOrDisconnect(object sender, EventArgs e)
        {

            BeginInvoke((MethodInvoker)(() => {
                try {
                    StatusPanel.Visible = true;

                    if (_obs.IsConnected) {
                        StatusPanel.BackColor = Color.Green;
                        StatusLabel.Text = "接続中";

                    }
                    else {
                        StatusPanel.BackColor = Color.Red;
                        StatusLabel.Text = "切断";
                        streamingStatus.Text = "";
                        RecordingStatus.Text = "";
                    }

                    StatusPanel.Refresh();

                    connectbtn.Text = _obs.IsConnected ? "切断" : "接続";
                    RefreshControlsStatus();

                    Thread.Sleep(2000);
                    StatusPanel.Visible = false;

                    if (!_obs.IsConnected) return;
                    var streamStatus = _obs.Api.GetStreamingStatus();
                    if (streamStatus.IsStreaming)
                        onStreamingStateChange(_obs, OutputState.Started);
                    else
                        onStreamingStateChange(_obs, OutputState.Stopped);

                    if (streamStatus.IsRecording)
                        onRecordingStateChange(_obs, OutputState.Started);
                    else
                        onRecordingStateChange(_obs, OutputState.Stopped);
                }
                catch (ErrorResponseException) {
                    MessageBox.Show("エラーが発生しました。Tailobsを再起動させてください。", "OBSの接続に失敗しました");
                    _obs.Disconnect();
                    ConnectOrDisconnect(null, null);
                    return;
                }
            }));

        }

        //Recording method
        private void onRecordingStateChange(ObsWebSocket sender, OutputState newState)
        {
            try {
                var state = "";
                var btnstate = "";

                switch (newState) {
                    case OutputState.Starting:
                        state = "録画開始中...";
                        btnstate = "開始中...";
                        break;

                    case OutputState.Started:
                        state = "録画中";
                        btnstate = "録画停止";
                        //Start Timer
                        BeginInvoke((MethodInvoker)delegate {
                            //LeftStoppingTimeSec = 5;
                            LimitTimer.Start();
                            IsRecording = true;
                        });

                        break;

                    case OutputState.Stopping:
                        state = "録画停止中...";
                        btnstate = "停止中...";

                        break;

                    case OutputState.Stopped:
                        state = "停止";
                        btnstate = "録画開始";

                        //Reset AddTme
                        BeginInvoke((MethodInvoker)delegate {
                            LimitTimer.Stop();
                            ReloadAddTime();
                            IsRecording = false;
                        });
                        break;

                    default:
                        state = "不明";
                        //Reset AddTme
                        BeginInvoke((MethodInvoker)delegate {
                            LimitTimer.Stop();
                            ReloadAddTime();
                        });

                        break;
                }

                BeginInvoke((MethodInvoker)delegate {
                    RecordingStatus.Text = state;
                    recordbtn.Text = btnstate;
                    if (state == "不明") recordbtn.Enabled = false;
                });

            }
            catch { }

        }

        //ToggleRecording
        private void recordbtn_Click(object sender, EventArgs e)
        {
            try {
                if (!_obs.IsConnected) {
                    MessageBox.Show("OBSに接続されていません。Tailobsを再起動させてください。", "エラー");
                    ConnectOrDisconnect(null, null);
                    return;
                }
                _obs.Api.ToggleRecording();
            }
            catch { }

        }

        //Streaminging method
        private void onStreamingStateChange(ObsWebSocket sender, OutputState newState)
        {
            string state = "";
            string btnstate = "";

            switch (newState) {
                case OutputState.Starting:
                    state = "配信開始中...";
                    btnstate = "開始中...";
                    break;

                case OutputState.Started:
                    state = "配信中";
                    btnstate = "配信停止";
                    break;

                case OutputState.Stopping:
                    state = "配信停止中...";
                    btnstate = "停止中...";

                    ResetStreamingStateText();

                    break;

                case OutputState.Stopped:
                    state = "停止";
                    btnstate = "配信開始";
                    break;

                default:
                    state = "不明";
                    break;
            }

            BeginInvoke((MethodInvoker)delegate {
                streamingStatus.Text = state;
                streamingbtn.Text = btnstate;
                if (state == "不明") streamingbtn.Enabled = false;
            });
        }

        private void streamingbtn_Click(object sender, EventArgs e)
        {
            try {
                if (!_obs.IsConnected) {
                    MessageBox.Show("OBSに接続されていません。Tailobsを再起動させてください。", "エラー");
                    return;
                }
                _obs.Api.ToggleStreaming();
            }
            catch { }

        }

        private void onStreamData(ObsWebSocket sender, StreamStatus data)
        {
            BeginInvoke((MethodInvoker)delegate {
                txtStreamTime.Text = data.TotalStreamTime.ToString() + " sec";
                txtKbitsSec.Text = data.KbitsPerSec.ToString() + " kbit/s";
                txtBytesSec.Text = data.BytesPerSec.ToString() + " bytes/s";
                txtFramerate.Text = data.FPS.ToString() + " FPS";
                txtDroppedFrames.Text = data.DroppedFrames.ToString();
                txtTotalFrames.Text = data.TotalFrames.ToString();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (!_obs.IsConnected) {
                    try {
                        //connect
                        Console.WriteLine(Properties.Settings.Default.obspassword);
                        _obs.Connect(Properties.Settings.Default.obsurl, Properties.Settings.Default.obspassword);
                    }
                    catch (AuthFailureException) {
                        MessageBox.Show("OBSが起動されている、またはアドレス、パスワードが正しいか確認してください。", "OBSの接続に失敗しました");
                        _obs.Disconnect();
                        return;
                    }
                    catch (ErrorResponseException) {
                        Console.WriteLine("あe");
                        _obs.Disconnect();
                        return;
                    }
                }
                else {
                    _obs.Disconnect();
                }

                //display running status
                ConnectOrDisconnect(null, null);
            }
            catch (ArgumentException) {
                MessageBox.Show("アドレスまたはパスワードが無効です。", "エラー");
                UrlTextbox.Text = "ws://127.0.0.1:4444";
            }

        }

        //Changed Password or Uri
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;

            if (textbox.Name == "UrlTextbox") {
                Properties.Settings.Default.obsurl = textbox.Text;
            }
            else if (textbox.Name == "PasswordTextbox") {
                Properties.Settings.Default.obspassword = textbox.Text;
            }

            Properties.Settings.Default.Save();
        }

        private void LimitTimer_Tick(object sender, EventArgs e)
        {
            try {
                //RestartTimer
                AddTimeLabel.Visible = false;

                if (LeftStoppingTimeSec <= 0) {
                    BeginInvoke((MethodInvoker) async delegate {
                        if (await MonitorEarthquake()) {
                            AddTimeLabel.Visible = true;
                            AddTimeLabel.Text = $"+ {LeftStoppingTimeSec}秒/{LeftStoppingTimeSec / 60}分";
                            return;
                        }
                        ReRecord();
                    });
                }
                LeftStoppingTimeSec--;
                //LeftStoppingTimeSec -= 10;
                RecordLimitTimeLabel.Text = $"{LeftStoppingTimeSec}秒/{LeftStoppingTimeSec / 60}分";
            }
            catch { }
        }

        //Recording stop and sleep and start
        async Task ReRecord()
        {
            BeginInvoke((MethodInvoker) async delegate {
                //stop
                _obs.Api.ToggleRecording();
                LimitTimer.Stop();
                ReloadAddTime();

                while (IsRecording) {
                    //IsRecording
                    await Task.Delay(1000);
                    
                }
                _obs.Api.ToggleRecording();
            });
        }

        private async Task<bool> MonitorEarthquake()
        {
            try {
                var eq = new kyoushinmonitor();
                if (await eq.IsEew()) {
                    //Exception
                    LeftStoppingTimeSec = Properties.Settings.Default.AddTime * 60;
                    return true;
                }
                return false;
            }
            catch { return false; }

        }

        private void timertime_TextChanged(object sender, EventArgs e)
        {
            try {
                var control = (TextBox)sender;
                var value = int.Parse(control.Text);

                if (value <= 0 || 100000000 <= value || control.Text == "") {
                    if (control.Name == "ExtensionTimeTextbox") {
                        ExtensionTimeTextbox.Text = Properties.Settings.Default.RecTime.ToString();
                    }
                    else if (control.Name == "AddExtensionTimeTextbox") {
                        AddExtensionTimeTextbox.Text = Properties.Settings.Default.AddTime.ToString();
                    }
                    MessageBox.Show($"上限は1分以上{100000000}分以下です。", "エラー");
                    return;
                }

                if (control.Name == "ExtensionTimeTextbox") {
                    Properties.Settings.Default.RecTime = value;
                }
                else if (control.Name == "AddExtensionTimeTextbox") {
                    Properties.Settings.Default.AddTime = value;
                }

                Properties.Settings.Default.Save();
                ReloadAddTime();
            }
            catch (OverflowException) {
                MessageBox.Show($"上限は1分以上{100000000}分以下です。", "エラー");
                return;
            }
            catch (FormatException) {
                MessageBox.Show($"上限は1分以上{100000000}分以下です。", "エラー");
                return;
            }
        }
    }
}
