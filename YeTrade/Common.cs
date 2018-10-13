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

    public class CSymbolNode
    {
        public string mTypeName;
        public List<string> mSymbols = new List<string>();
    }
    public class CSymbolTree
    {
        public List<CSymbolNode> mSymbolNodeList = new List<CSymbolNode>();
    }

    public class CBreakStrategy
    {
        //风险因子
        public double mRisk;
        //杠杆 50 100 200...
        public double mLeverage;
        //突破周期 20 50 100
        public int mBreakPeriod;
        //ATR周期
        public int mAtrPeriod;
        //收盘价止损 atr
        public double mCloseStopAtr;
        //即时止损 atr
        public double mImeStopAtr;
        //初始资金
        public double mMoney;
        //
    }
    public class CSymbol
    {
        //品种名
        public string mSymbolName;
        //价格
        public Dictionary<DateTime, CCandleData> mCandleData = new Dictionary<DateTime, CCandleData>();
        //价格周期
        public string mPricePeriod;
        //1手的量变化最小变化点位(tickSize)对应的金额
        public double mTickVal;
        //最小变化点位
        public double mTickSize;
        //每手合约大小
        public double mContractSize;
        //最小手数
        public double mMinVol;
        //最大手数
        public double mMaxVol;
        //最小变化手数
        public double mStepVol;
        //保证金比率 用于保证金计算
        public double mMarginRadio;

        public List<double> mPriceList = new List<double>();
        public bool mHasVol = false;
        //1:buy -1:sell
        public int mBuyOrSell = 0;
        public double calLoss(double vol,double point)
        {
            double re = 0;
            re = vol * (point / mTickSize) * mTickVal;
            return re;
        }
        public double calMargin(double vol,double price,double leverage)
        {
            double re = 0;
            re = vol * mContractSize * price * mMarginRadio / leverage;
            return re;
        }
        public void step(DateTime curTime,CBreakStrategy bs)
        {
            if (!mCandleData.ContainsKey(curTime))
                return;

            if(mPriceList.Count<bs.mBreakPeriod)
            {
                mPriceList.Add(mCandleData[curTime].mPrice.c);
            }
            else
            {
                if(mPriceList.Count>bs.mBreakPeriod)
                {
                    mPriceList.Add(mCandleData[curTime].mPrice.c);
                    mPriceList.RemoveAt(0);
                }
                if (!mHasVol)
                {
                    double highPrice = mPriceList.Max();
                    if (mPriceList.Last() > highPrice)
                    {
                        //break open vol buy
                    }

                    double lowPrice = mPriceList.Min();
                    if(mPriceList.Last() < lowPrice)
                    {
                        //break open vol sell

                    }
                }
                else
                {
                    //check stop

                }
            }
        }
    }
}
