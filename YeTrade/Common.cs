using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeTrade
{
    public class CConfig
    {
        public static string mServer;
        public static string mAccount;
        public static string mToken;
    }
    public class CCandleData
    {
        public OHLC mPrice;
        public DateTime mCandleTime;
        public CCandleData(OHLC ol,string dateStr)
        {
            mPrice = ol;
            mCandleTime = CHelp.str2Date(dateStr);
        }
        public CCandleData(OHLC ol,DateTime dt)
        {
            mPrice = ol;
            mCandleTime = dt;
        }
    }
    public struct OHLC
    {
        public double o { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public double c { get; set; }
    }
    public class Candle
    {
        public bool complete { get; set; }
        public int volume { get; set; }
        public string time { get; set; }
        public OHLC ask { get; set; }
        public OHLC bid { get; set; }
        public override string ToString()
        {
            return time + "," + ask.o + "," + bid.o + "," + ask.h + "," + bid.h + ","
                + ask.l + "," + bid.l + "," + ask.c + "," + bid.c + "," + volume;
        }
    }
    public class Instrument
    {
        public string instrument { get; set; }
        public string granularity { get; set; }
        public List<Candle> candles { get; set; }
        public Instrument()
        {
            candles = new List<Candle>();
        }
    }
}
