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
        internal partial class Dictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue>
        {
            internal new virtual void Add(TKey key, TValue value)
            {
                if (base.ContainsKey(key))
                {
                    throw new Exception();
                }
                else
                {
                    base.Add(key, value);
                }
            }
        }
        public StockItem CreateStockItem(int code, string name, int quantityInStock)
        {
            StockItem stockitem = new StockItem(code, name, quantityInStock); // Create new instance object
            StockItems.Add(Id, stockitem); //Dictionary add key-value
            Id++;
            //StockItem item = FindStockItem(code);
            // The Add method throws an exception if the new key is already in the dictionary.

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
            if(stockitem == null)
            {
                throw new Exception("Stock item "+code+" not found. Quantity not removed.");
            }
            else
            {
                stockitem.QuantityInStock -= quantityToRemove;
            }
            return stockitem;
        }
        public StockItem DeleteStockItem(int code)
        {
            StockItem stockitem = FindStockItem(code); // found the item
            if(stockitem == null)
            {
                throw new Exception("Item has not been deleted because it cannot be found");
            }
            else if (stockitem.QuantityInStock > 0)
            {
                throw new Exception("Item cannot be deleted because quantity in stock is not zero");
            }
            else
            {
                StockItems.Remove(code); //NOT WORKING CODE
            }
            
            return stockitem;
        }
    }
}
