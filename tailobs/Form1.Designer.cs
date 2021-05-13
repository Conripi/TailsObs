namespace tailobs
{
    partial class tailobs
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectbtn = new System.Windows.Forms.Button();
            this.UrlTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.recordbtn = new System.Windows.Forms.Button();
            this.streamingbtn = new System.Windows.Forms.Button();
            this.RecordingStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddExtensionTimeTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExtensionTimeTextbox = new System.Windows.Forms.TextBox();
            this.RecordLimitTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDroppedFrames = new System.Windows.Forms.Label();
            this.txtTotalFrames = new System.Windows.Forms.Label();
            this.txtBytesSec = new System.Windows.Forms.Label();
            this.txtKbitsSec = new System.Windows.Forms.Label();
            this.txtFramerate = new System.Windows.Forms.Label();
            this.txtStreamTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.streamingStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(254, 12);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 0;
            this.connectbtn.Text = "接続";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrlTextbox
            // 
            this.UrlTextbox.AccessibleDescription = "URL";
            this.UrlTextbox.Location = new System.Drawing.Point(12, 14);
            this.UrlTextbox.Name = "UrlTextbox";
            this.UrlTextbox.Size = new System.Drawing.Size(100, 19);
            this.UrlTextbox.TabIndex = 1;
            this.UrlTextbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.AccessibleDescription = "PASSWORD";
            this.PasswordTextbox.Location = new System.Drawing.Point(135, 14);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 19);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusPanel.Location = new System.Drawing.Point(0, 466);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(348, 22);
            this.StatusPanel.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(149, -1);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 21);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordbtn
            // 
            this.recordbtn.Location = new System.Drawing.Point(201, 27);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(98, 23);
            this.recordbtn.TabIndex = 4;
            this.recordbtn.Text = "録画開始";
            this.recordbtn.UseVisualStyleBackColor = true;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // streamingbtn
            // 
            this.streamingbtn.Location = new System.Drawing.Point(201, 32);
            this.streamingbtn.Name = "streamingbtn";
            this.streamingbtn.Size = new System.Drawing.Size(98, 23);
            this.streamingbtn.TabIndex = 5;
            this.streamingbtn.Text = "配信開始";
            this.streamingbtn.UseVisualStyleBackColor = true;
            this.streamingbtn.Click += new System.EventHandler(this.streamingbtn_Click);
            // 
            // RecordingStatus
            // 
            this.RecordingStatus.AutoSize = true;
            this.RecordingStatus.Location = new System.Drawing.Point(88, 32);
            this.RecordingStatus.Name = "RecordingStatus";
            this.RecordingStatus.Size = new System.Drawing.Size(0, 12);
            this.RecordingStatus.TabIndex = 6;
            this.RecordingStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddTimeLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddExtensionTimeTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ExtensionTimeTextbox);
            this.groupBox1.Controls.Add(this.RecordLimitTimeLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RecordingStatus);
            this.groupBox1.Controls.Add(this.recordbtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "録画";
            // 
            // AddTimeLabel
            // 
            this.AddTimeLabel.AutoSize = true;
            this.AddTimeLabel.ForeColor = System.Drawing.Color.Red;
            this.AddTimeLabel.Location = new System.Drawing.Point(209, 70);
            this.AddTimeLabel.Name = "AddTimeLabel";
            this.AddTimeLabel.Size = new System.Drawing.Size(0, 12);
            this.AddTimeLabel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "延長時間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "録画周期";
            // 
            // AddExtensionTimeTextbox
            // 
            this.AddExtensionTimeTextbox.Location = new System.Drawing.Point(84, 134);
            this.AddExtensionTimeTextbox.Name = "AddExtensionTimeTextbox";
            this.AddExtensionTimeTextbox.Size = new System.Drawing.Size(100, 19);
            this.AddExtensionTimeTextbox.TabIndex = 12;
            this.AddExtensionTimeTextbox.TextChanged += new System.EventHandler(this.timertime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "単位: 分";
            // 
            // ExtensionTimeTextbox
            // 
            this.ExtensionTimeTextbox.Location = new System.Drawing.Point(84, 102);
            this.ExtensionTimeTextbox.Name = "ExtensionTimeTextbox";
            this.ExtensionTimeTextbox.Size = new System.Drawing.Size(100, 19);
            this.ExtensionTimeTextbox.TabIndex = 10;
            this.ExtensionTimeTextbox.TextChanged += new System.EventHandler(this.timertime_TextChanged);
            // 
            // RecordLimitTimeLabel
            // 
            this.RecordLimitTimeLabel.AutoSize = true;
            this.RecordLimitTimeLabel.Location = new System.Drawing.Point(88, 70);
            this.RecordLimitTimeLabel.Name = "RecordLimitTimeLabel";
            this.RecordLimitTimeLabel.Size = new System.Drawing.Size(11, 12);
            this.RecordLimitTimeLabel.TabIndex = 9;
            this.RecordLimitTimeLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "停止時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "録画状態 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.streamingStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.streamingbtn);
            this.groupBox2.Location = new System.Drawing.Point(14, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 238);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配信";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDroppedFrames);
            this.groupBox3.Controls.Add(this.txtTotalFrames);
            this.groupBox3.Controls.Add(this.txtBytesSec);
            this.groupBox3.Controls.Add(this.txtKbitsSec);
            this.groupBox3.Controls.Add(this.txtFramerate);
            this.groupBox3.Controls.Add(this.txtStreamTime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(19, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 161);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "スターテス";
            // 
            // txtDroppedFrames
            // 
            this.txtDroppedFrames.AutoSize = true;
            this.txtDroppedFrames.Location = new System.Drawing.Point(118, 139);
            this.txtDroppedFrames.Name = "txtDroppedFrames";
            this.txtDroppedFrames.Size = new System.Drawing.Size(11, 12);
            this.txtDroppedFrames.TabIndex = 21;
            this.txtDroppedFrames.Text = "0";
            // 
            // txtTotalFrames
            // 
            this.txtTotalFrames.AutoSize = true;
            this.txtTotalFrames.Location = new System.Drawing.Point(118, 116);
            this.txtTotalFrames.Name = "txtTotalFrames";
            this.txtTotalFrames.Size = new System.Drawing.Size(11, 12);
            this.txtTotalFrames.TabIndex = 20;
            this.txtTotalFrames.Text = "0";
            // 
            // txtBytesSec
            // 
            this.txtBytesSec.AutoSize = true;
            this.txtBytesSec.Location = new System.Drawing.Point(118, 93);
            this.txtBytesSec.Name = "txtBytesSec";
            this.txtBytesSec.Size = new System.Drawing.Size(11, 12);
            this.txtBytesSec.TabIndex = 19;
            this.txtBytesSec.Text = "0";
            // 
            // txtKbitsSec
            // 
            this.txtKbitsSec.AutoSize = true;
            this.txtKbitsSec.Location = new System.Drawing.Point(118, 70);
            this.txtKbitsSec.Name = "txtKbitsSec";
            this.txtKbitsSec.Size = new System.Drawing.Size(11, 12);
            this.txtKbitsSec.TabIndex = 18;
            this.txtKbitsSec.Text = "0";
            // 
            // txtFramerate
            // 
            this.txtFramerate.AutoSize = true;
            this.txtFramerate.Location = new System.Drawing.Point(118, 46);
            this.txtFramerate.Name = "txtFramerate";
            this.txtFramerate.Size = new System.Drawing.Size(11, 12);
            this.txtFramerate.TabIndex = 17;
            this.txtFramerate.Text = "0";
            // 
            // txtStreamTime
            // 
            this.txtStreamTime.AutoSize = true;
            this.txtStreamTime.Location = new System.Drawing.Point(118, 24);
            this.txtStreamTime.Name = "txtStreamTime";
            this.txtStreamTime.Size = new System.Drawing.Size(11, 12);
            this.txtStreamTime.TabIndex = 16;
            this.txtStreamTime.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "ドロップフレーム";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "データ量 / bytes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "データ量 / kbits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "全フレームレート";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "フレームレート";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "配信時間";
            // 
            // streamingStatus
            // 
            this.streamingStatus.AutoSize = true;
            this.streamingStatus.Location = new System.Drawing.Point(90, 37);
            this.streamingStatus.Name = "streamingStatus";
            this.streamingStatus.Size = new System.Drawing.Size(0, 12);
            this.streamingStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "録画状態 :";
            // 
            // LimitTimer
            // 
            this.LimitTimer.Interval = 1000;
            this.LimitTimer.Tick += new System.EventHandler(this.LimitTimer_Tick);
            // 
            // tailobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UrlTextbox);
            this.Controls.Add(this.connectbtn);
            this.Name = "tailobs";
            this.Text = "TailsOBS";
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox UrlTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.Button streamingbtn;
        private System.Windows.Forms.Label RecordingStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label streamingStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordLimitTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExtensionTimeTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddExtensionTimeTextbox;
        private System.Windows.Forms.Timer LimitTimer;
        private System.Windows.Forms.Label AddTimeLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtStreamTime;
        private System.Windows.Forms.Label txtDroppedFrames;
        private System.Windows.Forms.Label txtTotalFrames;
        private System.Windows.Forms.Label txtBytesSec;
        private System.Windows.Forms.Label txtKbitsSec;
        private System.Windows.Forms.Label txtFramerate;
    }
}

