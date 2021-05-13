using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tailobs.NTP
{
    public class ntp
    {
        public static DateTime GetDateTimeNow()
        {
            try
            {
                var ip = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
                var udp = new System.Net.Sockets.UdpClient(ip);
                var sendData = new Byte[48];
                sendData[0] = 0xB;
                udp.Send(sendData, 48, "time.windows.com", 123);
                var receiveData = udp.Receive(ref ip);
                var totalSeconds = (long)(
                            receiveData[40] * Math.Pow(2, (8 * 3)) +
                            receiveData[41] * Math.Pow(2, (8 * 2)) +
                            receiveData[42] * Math.Pow(2, (8 * 1)) +
                            receiveData[43]);
                var utcTime = new DateTime(1900, 1, 1).AddSeconds(totalSeconds);
                return TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfo.Local);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return DateTime.MinValue;
            }
        }
    }
}
