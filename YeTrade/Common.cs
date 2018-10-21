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
        public CCandleData()
        {

        }
        public CCandleData(OHLC ol,string dateStr)
        {
            mPrice = ol;
            mCandleTime = CHelp.str2Date(dateStr).Date;
        }
        public CCandleData(OHLC ol,DateTime dt)
        {
            mPrice = ol;
            mCandleTime = dt.Date;
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
        public OHLC mid { get; set; }
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

    public class CCandleDataWrap
    {
        public Dictionary<DateTime, CCandleData> mPrice = new Dictionary<DateTime, CCandleData>();
        public CCandleDataWrap(Dictionary<DateTime, CCandleData> r)
        {
            mPrice = r;
        }
    }

    public class CSymbolPro
    {
        public string mSymbolTypeName;
        public string mSymbolName;
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
    }
    public class CSymbolNode
    {
        public string mTypeName;
        public List<CSymbolPro> mSymbols = new List<CSymbolPro>();
    }
    public class CSymbolTree
    {
        public List<CSymbolNode> mSymbolNodeList = new List<CSymbolNode>();
    }

    public class CBreakStrategy
    {
        //总风险因子
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
        //总品种数
        public int mSymbolCount;

        public void initHuiChe(DateTime t)
        {
            mHuiChe.init(mMoney, t);
        }
        public void changeMoney(DateTime t,string symbolType,string symbol,double profit)
        {
            mMoney += profit;

            mProfitChange.Add(new CProfitChange(symbolType,symbol, t, profit));
            mHuiChe.update(mMoney, t);
        }

        public void addMoneyLine(DateTime t)
        {
            mMoneyLine[t] = mMoney;
        }
        public Dictionary<DateTime, double> mMoneyLine = new Dictionary<DateTime, double>();
        public CHuiChe mHuiChe = new CHuiChe();
        public List<CProfitChange> mProfitChange = new List<CProfitChange>();
    }
    public class CProfitChange
    {
        public string mSymbolType;
        public string mSymbol;
        public DateTime mTime;
        public double mProfit;
        public CProfitChange(string st,string s,DateTime d,double p)
        {
            mSymbolType = st;
            mSymbol = s;
            mTime = d;
            mProfit = p;
        }
    }
    public class CHuiChe
    {
        public double mHuiCheRadio;
        public DateTime mHighTime;
        public DateTime mLowTime;

        double mHighMoney;
        public DateTime mHighMoneyTime;

        public CHuiChe()
        {
            mHighMoney = 0;
            mHuiCheRadio = 0;
        }
        public void init(double m,DateTime t)
        {
            mHuiCheRadio = 0;
            mHighTime = t;
            mLowTime = t;
            mHighMoney = m;
            mHighMoneyTime = t;
        }
        public void update(double curMoney,DateTime curTime)
        {
            if(curMoney>mHighMoney)
            {
                mHighMoneyTime = curTime;
                mHighMoney = curMoney;
            }
            else
            {
                double huiChe = (mHighMoney - curMoney) / mHighMoney;
                if(huiChe>mHuiCheRadio)
                {
                    mHuiCheRadio = huiChe;
                    mLowTime = curTime;
                    mHighTime = mHighMoneyTime;
                }
            }
        }
    }
    public class CSymbol
    {
        public CSymbolPro mPro = new CSymbolPro();
        //价格
        public Dictionary<DateTime, CCandleData> mCandleData = new Dictionary<DateTime, CCandleData>();

        public List<OHLC> mPriceList = new List<OHLC>();
        public bool mHasVol = false;
        public double mTradePrice;
        public double mCloseStopPrice;
        public double mImeStopPrice;
        public double mVol;
        //1:buy -1:sell
        public int mBuyOrSell = 0;
        public string getSettleCurrency()
        {
            return mPro.mSymbolName.Substring(mPro.mSymbolName.IndexOf("_") + 1);
        }
        public double toCuy(double dollar,DateTime d)
        {
            string cry = getSettleCurrency();
            if (cry == "USD")
            {
                return dollar;
            }
            else
            {
                return dollar / CHelp.toUSD(cry, d);
            }
        }
        public double toUSD(double v,DateTime d)
        {
            string cry = getSettleCurrency();
            if (cry == "USD")
            {
                return v;
            }
            else
            {
                return v*CHelp.toUSD(cry, d);
            }
        }
        public double calLoss(double vol,double point,DateTime d)
        {
            double re = 0;
            re = vol * (point / mPro.mTickSize) * mPro.mTickVal;

            return toUSD(re,d);
        }
        /*
        public double calMargin(double vol,double price,double leverage)
        {
            double re = 0;
            re = vol * mPro.mContractSize * price * mPro.mMarginRadio / leverage;
            return re;
        }
        */
        public double getVol(CBreakStrategy bs,double point,DateTime d)
        {
            double loss = bs.mMoney * bs.mRisk / 100 / bs.mSymbolCount;
            loss = toCuy(loss, d);
            double v = loss / mPro.mTickVal / (point / mPro.mTickSize);

            int howV = (int)(v / mPro.mStepVol);
            v = howV * mPro.mStepVol;

            if (v < mPro.mMinVol)
                v = mPro.mMinVol;
            if (v > mPro.mMaxVol)
                v = mPro.mMaxVol;

            return v;
        }

        //0:no break 1:buy -1:sell
        int checkBreak(CBreakStrategy bs)
        {
            int re = 0;

            List<OHLC> breakList = mPriceList.Skip(Math.Max(0, mPriceList.Count() - bs.mBreakPeriod)).ToList();
            double highPrice = breakList.Take(bs.mBreakPeriod - 1).Select(i=>i.c).Max();
            if (breakList.Last().c > highPrice)
            {
                re = 1;
            }

            double lowPrice = breakList.Take(bs.mBreakPeriod - 1).Select(i=>i.c).Min();
            if (breakList.Last().c < lowPrice)
            {
                re = -1;
            }
            return re;
        }
        double calAtr(CBreakStrategy bs)
        {
            double re = 0;

            List<OHLC> atrList = mPriceList.Skip(Math.Max(0, mPriceList.Count() - bs.mAtrPeriod)).ToList();
            List<double> mtr = new List<double>();
            for(int i=atrList.Count-1;i>0;i--)
            {
                OHLC pre = atrList[i - 1];
                OHLC cur = atrList[i];

                double[] m = { Math.Abs(cur.h - cur.l), Math.Abs(cur.h - pre.c), Math.Abs(cur.l - pre.c) };
                mtr.Add(m.Max());
            }
            re = mtr.Average();

            return re;
        }
        public void step(DateTime curTime,CBreakStrategy bs)
        {
            if (!mCandleData.Keys.Contains(curTime.Date))
                return;

            OHLC prePrice = mCandleData[curTime].mPrice;

            if (mPriceList.Count < bs.mBreakPeriod - 1 || mPriceList.Count < bs.mAtrPeriod - 1)
            {
                mPriceList.Add(prePrice);
            }
            else
            {
                mPriceList.Add(prePrice);

                int bigPeriod = bs.mBreakPeriod > bs.mAtrPeriod ? bs.mBreakPeriod : bs.mAtrPeriod;
                while (mPriceList.Count > bigPeriod)
                    mPriceList.RemoveAt(0);

                double atr = calAtr(bs);

                if (!mHasVol)
                {
                    int breakRe = checkBreak(bs);
                    if(breakRe == 1)
                    {
                        //break open vol buy
                        mBuyOrSell = 1;
                        mTradePrice = prePrice.c;

                        mCloseStopPrice = prePrice.c - atr * bs.mCloseStopAtr;
                        mImeStopPrice = prePrice.c - atr * bs.mImeStopAtr;

                        mVol = getVol(bs, atr * (bs.mCloseStopAtr > bs.mImeStopAtr ? bs.mCloseStopAtr : bs.mImeStopAtr), curTime);

                        mHasVol = true;

                        Log4netHelper.LogInfo("symbol:"+mPro.mSymbolName+" buy:" + mVol.ToString("F2") + " price:" + mTradePrice.ToString("F2") + " time:" + curTime.ToShortDateString());
                    }
                    if(breakRe == -1)
                    {
                        //break open vol sell
                        mBuyOrSell = -1;
                        mTradePrice = prePrice.c;

                        mCloseStopPrice = prePrice.c + atr * bs.mCloseStopAtr;
                        mImeStopPrice = prePrice.c + atr * bs.mImeStopAtr;

                        mVol = getVol(bs, atr * (bs.mCloseStopAtr > bs.mImeStopAtr ? bs.mCloseStopAtr : bs.mImeStopAtr), curTime);

                        mHasVol = true;

                        Log4netHelper.LogInfo("symbol:" + mPro.mSymbolName + " sell:" + mVol.ToString("F2") + " price:" + mTradePrice.ToString("F2") + " time:" + curTime.ToShortDateString());
                    }
                }
                else
                {
                    bool stop = false;
                    //check stop
                    if(mBuyOrSell==1)
                    {
                        if(!stop && prePrice.l<mImeStopPrice)
                        {
                            stop = true;
                            double profit = calLoss(mVol, mImeStopPrice - mTradePrice,curTime);
                            bs.changeMoney(curTime, mPro.mSymbolTypeName, mPro.mSymbolName, profit);

                            Log4netHelper.LogInfo("symbol:" + mPro.mSymbolName + " buy stop at ime price:" + mImeStopPrice.ToString("F2") + " profit:" + profit.ToString("F2")
                                + " all_money:"+bs.mMoney.ToString("F2")
                                + " time:" + curTime.ToShortDateString());
                        }
                        if (!stop && prePrice.c<mCloseStopPrice)
                        {
                            stop = true;
                            double profit = calLoss(mVol, prePrice.c - mTradePrice,curTime);
                            bs.changeMoney(curTime, mPro.mSymbolTypeName, mPro.mSymbolName, profit);

                            Log4netHelper.LogInfo("symbol:" + mPro.mSymbolName + " buy stop at close price:" + prePrice.c.ToString("F2") + " profit:" + profit.ToString("F2")
                                + " all_money:" + bs.mMoney.ToString("F2")
                                + " time:" + curTime.ToShortDateString());
                        }
                        if(!stop)
                        {
                            double newCloseStopPrice = prePrice.c - bs.mCloseStopAtr * atr;
                            double newImeStopPrice = prePrice.c - bs.mImeStopAtr * atr;
                            if (newCloseStopPrice > mCloseStopPrice)
                                mCloseStopPrice = newCloseStopPrice;
                            if (newImeStopPrice > mImeStopPrice)
                                mImeStopPrice = newImeStopPrice;

                            //Log4netHelper.LogInfo(string.Format("buy update price:close price-{0} ime price-{1}", mCloseStopPrice.ToString("F2"), mImeStopPrice.ToString("F2")));
                        }
                    }
                    if(mBuyOrSell == -1)
                    {
                        if (!stop && prePrice.h > mImeStopPrice)
                        {
                            stop = true;
                            double profit = calLoss(mVol, mTradePrice - mImeStopPrice,curTime);
                            bs.changeMoney(curTime, mPro.mSymbolTypeName, mPro.mSymbolName, profit);

                            Log4netHelper.LogInfo("symbol:" + mPro.mSymbolName + " sell stop at ime price:" + mImeStopPrice.ToString("F2") + " profit:" + profit.ToString("F2")
                                + " all_money:" + bs.mMoney.ToString("F2")
                                + " time:" + curTime.ToShortDateString());
                        }
                        if (!stop && prePrice.c > mCloseStopPrice)
                        {
                            stop = true;
                            double profit = calLoss(mVol, mTradePrice - prePrice.c,curTime);
                            bs.changeMoney(curTime, mPro.mSymbolTypeName, mPro.mSymbolName, profit);

                            Log4netHelper.LogInfo("symbol:" + mPro.mSymbolName + " sell stop at close price:" + prePrice.c.ToString("F2") + " profit:" + profit.ToString("F2")
                                + " all_money:" + bs.mMoney.ToString("F2")
                                + " time:" + curTime.ToShortDateString());
                        }
                        if (!stop)
                        {
                            double newCloseStopPrice = prePrice.c + bs.mCloseStopAtr * atr;
                            double newImeStopPrice = prePrice.c + bs.mImeStopAtr * atr;
                            if (newCloseStopPrice < mCloseStopPrice)
                                mCloseStopPrice = newCloseStopPrice;
                            if (newImeStopPrice < mImeStopPrice)
                                mImeStopPrice = newImeStopPrice;

                            //Log4netHelper.LogInfo(string.Format("sell update price:close price-{0} ime price-{1}", mCloseStopPrice.ToString("F2"), mImeStopPrice.ToString("F2")));
                        }
                    }
                    if(stop)
                    {
                        mHasVol = false;
                    }

                }
            }
        }
    }
}
