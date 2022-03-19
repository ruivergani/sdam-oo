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
        private static int nextId = 1;
        public int Id { get; set; }

        public StockManager(SortedDictionary<int, StockItem> stockItems)
        {
            Id = nextId++;
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
        public StockItem CreateStockItem(int code, string name, int quantityInStock)
        {
            StockItem stockitem = null;
            StockItems.Add(Id, stockitem);
            Id++; // increment the ID
            return stockitem;
        }

    }
}
