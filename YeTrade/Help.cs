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
using System.Collections;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

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
        
        public static double toUSD(string currency,DateTime d)
        {
            double re = 1.0;

            if (currency == "USD")
                re = 1.0;
            else
            {
                string symbol = "";

                if(currency == "JPY")
                {
                    symbol = "USD_JPY";
                }
                if (currency == "GBP")
                {
                    symbol = "GBP_USD";
                }
                if (currency == "EUR")
                {
                    symbol = "EUR_USD";
                }
                if (currency == "CHF")
                {
                    symbol = "USD_CHF";
                }
                if (currency == "CAD")
                {
                    symbol = "USD_CAD";
                }
                if (currency == "AUD")
                {
                    symbol = "AUD_USD";
                }
                if (currency == "NZD")
                {
                    symbol = "NZD_USD";
                }
                if (currency == "HKD")
                {
                    symbol = "USD_HKD";
                }
                OHLC p = new OHLC();
                getRecentPrice(symbol, d, out p);
                if(symbol.StartsWith("USD"))
                {
                    return 1.0 / p.c;
                }
                else
                {
                    return p.c;
                }
              
                /*
                OHLC p = new OHLC();
                string symbol = currency + "_USD";
                bool hasP = getRecentPrice(symbol, d, out p);
                if(hasP)
                {
                    re = p.c;
                }
                if(!hasP)
                {
                    symbol = "USD_" + currency;
                    hasP = getRecentPrice(symbol, d, out p);
                    re = 1/p.c;
                }
                */

            }
            
            return re;
        }
        public static bool getRecentPrice(string symbol,DateTime d, out OHLC re,string gran = "D")
        {
            bool r = true;
            re = new OHLC();
            try
            {
                string requestString = CConfig.mServer + "/v3/instruments/" + symbol + "/candles";
                requestString = requestString + "?" + "price=ABM&from=" + date2Str(d) +"&count=1&granularity=" + gran;
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

                    foreach (var v in im.candles)
                    {
                        re = v.mid;
                    }
                }
            

            }
            catch(Exception)
            {
                r = false;
            }
            return r;
        }
        public static Dictionary<DateTime,CCandleData> getCandleHistoryData(string symbol,DateTime start,DateTime end, string gran="D")
        {
            Dictionary<DateTime, CCandleData> re = new Dictionary<DateTime, CCandleData>();

            try
            {
                string requestString = CConfig.mServer + "/v3/instruments/" + symbol + "/candles";
                requestString = requestString + "?" + "price=ABM&from=" + date2Str(start) + "&to=" + date2Str(end) + "&granularity=" + gran;
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
                            re[dt.Date] = new CCandleData(v.mid, dt);
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

    public class Log4netHelper
    {
        private Log4netHelper() { }

        //创建静态单实例类
        public static readonly Log4netHelper instance = new Log4netHelper();

        //记录日志
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #region
        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="errModule">errModule模块信息</param>
        /// <param name="ex">异常对象</param>
        public static void LogError(String errModule, Exception ex)
        {

            lock (log)
            {

                log.Error(errModule + "错误消息:" + ex.Message.ToString() + "\n" + ex.StackTrace);
            }


        }
        #endregion

        #region 记录异常信息
        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="ex">异常对象</param>
        public static void LogError(Exception ex)
        {


            lock (log)
            {
                StringBuilder strError = new StringBuilder();
                strError.AppendFormat(ex.ToString()).Append("\n");
                if (ex.Data.Count > 0)
                {
                    strError.AppendFormat("扩展信息:\n");

                    foreach (DictionaryEntry data in ex.Data)
                    {
                        strError.AppendFormat(data.Key.ToString()).Append(":").Append(data.Value.ToString()).Append("\n");
                    }
                }
                log.Error(strError.ToString());
                strError.AppendFormat(ex.StackTrace + "\n");
                //DebugHelper.RecordError(strError.ToString());

            }


        }
        #endregion

        #region 记录错误信息

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="errModule">errModule模块信息</param>
        /// <param name="message">错误消息</param>
        public static void LogError(String errModule, string message)
        {


            lock (log)
            {
                log.Error(errModule + "错误消息:" + message);
            }

        }
        #endregion

        #region 记录警告信息
        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="Module">errModule模块信息</param>
        /// <param name="Message">警告信息</param>
        public static void LogWarn(String Module, string Message)
        {
            lock (log)
            {
                log.Warn("在:" + Module + "模块,警告信息:" + Message + "\n");


            }

        }
        #endregion

        #region 记录普通信息
        /// <summary>
        /// 记录普通信息
        /// </summary>

        /// <param name="Message">信息内容</param>
        public static void LogInfo(string Message)
        {
            lock (log)
            {
                log.Info(Message);
            }

        }
        #endregion

        #region 记录调试信息
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="Message">信息内容</param>
        public static void LogDebug(string Message)
        {
            lock (log)
            {
                log.Debug(Message + "\n");
            }

        }
        #endregion
    }

}
