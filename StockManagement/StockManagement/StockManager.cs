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
        public int nextId = 1;
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
            stockitem = new StockItem(code, name, quantityInStock); // Create new instance object
            StockItems.Add(Id, stockitem); //Dictionary Add value
            Id++; // increment the ID
            //StockItem item = FindStockItem(code);
            return stockitem;
        }
        public StockItem FindStockItem(int code)
        {
            StockItem item = null; // Return null if does not exist
            for (int i = 0; i < StockItems.Count; i++) // Reading through the Dictionary
            {
                if(StockItems[i].Code == code) // match the code of the product
                {
                    item = StockItems[i]; //Override the null
                }
            }
            return item; // return product found
        }
        public StockItem AddQuantityToStockItem(int code, int quantityToAdd)
        {
            StockItem stockitem;
            stockitem = FindStockItem(code);
            if (stockitem == null)
            {
                throw new Exception("Stock item "+code+" not found. Quantity not added.");
            }
            else
            {
                stockitem.QuantityInStock += quantityToAdd; // Append into QuantityInStock
            }
            
            return stockitem;
        }
        public StockItem RemoveQuantityFromStockItem(int code, int quantityToRemove)
        {
            StockItem stockitem;
            stockitem = FindStockItem(code);
            stockitem.QuantityInStock -= quantityToRemove;
            return stockitem;
        }
    }
}
