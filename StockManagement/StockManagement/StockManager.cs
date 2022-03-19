using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class StockManager
    {

        //Attributes
        SortedDictionary<int, StockItem> StockItems
            = new SortedDictionary<int, StockItem>();

        public StockManager(SortedDictionary<int, StockItem> stockItems)
        {
            StockItems = stockItems;
        }
        public StockManager()
        {

        }


        //Methods
        public SortedDictionary<int, StockItem> GetAllStockItems()
        {
            return StockItems;
        }
    }
}
