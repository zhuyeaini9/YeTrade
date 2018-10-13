using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SQLite;

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

        public static Dictionary<DateTime,CCandleData> getCandleHistoryData(string symbol,DateTime start,DateTime end, string gran="D")
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
                MessageBox.Show(symbol+ex.ToString());
            }

            return re;
        }


    }

    public class CSqliteDBHelp
    {
        public static string mConnStr = @"Data Source=DB/Trade.db;";

        public static int executeSql(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(mConnStr);
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            return result;
        }

        public static DataTable getTable(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(mConnStr);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            da.Dispose();
            conn.Close();

            return dt;
        }

        public static object getValue(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(mConnStr);
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            conn.Open();
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();

            return result;
        }
    }
}
