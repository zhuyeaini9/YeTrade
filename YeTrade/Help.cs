using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace YeTrade
{
    public class CHelp
    {
        public static void loadConfig()
        {
            CConfig.mServer = ConfigurationManager.AppSettings["Server"];
            CConfig.mAccount = ConfigurationManager.AppSettings["Account"];
            CConfig.mToken = ConfigurationManager.AppSettings["Token"];
        }
        public static DateTime str2Date(string s)
        {
            return XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.Utc);
        }
        public static string date2Str(DateTime s)
        {
            return XmlConvert.ToString(s, XmlDateTimeSerializationMode.Utc);
        }

        public static Dictionary<DateTime,CCandleData> getCandleHistoryData(string symbol,DateTime start,DateTime end, string gran)
        {
            Dictionary<DateTime, CCandleData> re = new Dictionary<DateTime, CCandleData>();

            try
            {
                string requestString = CConfig.mServer + "/v3/instruments/" + symbol + "/candles";
                requestString = requestString + "?" + "price=AB&from=" + date2Str(start) + "&to=" + date2Str(end) + "&granularity=" + gran;
                HttpWebRequest request = WebRequest.CreateHttp(requestString);
                request.Headers[HttpRequestHeader.Authorization] = "Bearer " + CConfig.mToken;
                request.Method = "GET";
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new WebException("Web request error.");
                    }
                    Stream s = response.GetResponseStream();
                    StreamReader sr = new StreamReader(s);
                    var jr = new JsonTextReader(sr);
                    var serializer = new JsonSerializer();
                    Instrument im = serializer.Deserialize<Instrument>(jr);

                    foreach(var v in im.candles)
                    {
                        DateTime dt = str2Date(v.time);
                        if(!re.ContainsKey(dt))
                        {
                            re[dt] = new CCandleData(v.ask, dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return re;
        }
    }
}
