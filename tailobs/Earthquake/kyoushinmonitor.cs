using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tailobs.Earthquake
{
    public class kyoushinmonitor
    {
        public async Task<bool> IsEew()
        {
            try
            {
                var url = $"http://www.kmoni.bosai.go.jp/webservice/hypo/eew/{NTP.ntp.GetDateTimeNow():yyyyMMddHHmmss}";
                var html = await GetHtml(url);
                return html.Contains("データがありません") ? false : true;
            }
            catch
            {
                return false;
            }
            
        }

        public async Task<string> GetHtml(string html)
        {
            try {
                using (var c = new WebClient {
                    Encoding = Encoding.UTF8
                }) {
                    return await c.DownloadStringTaskAsync(html);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;

            }
        }
    }
}
