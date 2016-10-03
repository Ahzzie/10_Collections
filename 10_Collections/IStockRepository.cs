using System.Collections.Generic;

namespace _10_Collections
{
        internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock stock);
        Stock LoadStock(long id);
        Dictionary<long, Stock> FindAllStocks();
        void Clear();
    }
}