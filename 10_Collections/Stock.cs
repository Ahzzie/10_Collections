namespace _10_Collections
{
    public class Stock : IAsset

    {
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object stocks)
        {
            if (stocks is Stock)
            {
                Stock s = (Stock)stocks;
                if (symbol == s.Symbol && pricepershare == s.PricePerShare && numshares == s.NumShares)
                    return true;
                else
                    return false;
            }
            return false;

        }
        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString().Replace(',', '.') + ",numShares=" + NumShares + "]";
        }
        public Stock(string v1, double v2, int v3)
        {
            symbol = v1;
            pricepershare = v2;
            numshares = v3;
        }
        public Stock()
        {
        }
        private double pricepershare;
        private string symbol;
        private int numshares;

       

        public int NumShares
        {
            get { return numshares; }
            set { numshares = value; }
        }
        public double PricePerShare
        {
            get { return pricepershare; }
            set { pricepershare = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public long Id
        {
            get;
            set;
        }

        public double GetValue()
        {
            double getValue = NumShares * PricePerShare;
            return getValue;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double value = 0;

            foreach (IAsset stock in stocks)
            {
                value += stock.GetValue();
            }

            return value;
        }

        public string GetName()
        {
            return Symbol;
        }
    }
}
