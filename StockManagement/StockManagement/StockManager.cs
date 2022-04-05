using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class StockManager
    {
        //Attributes
        public SortedDictionary<int, StockItem> StockItems { get; private set; }
        public  StockManager()
        {
            StockItems = new SortedDictionary<int, StockItem>();
        }
        //Methods
        public SortedDictionary<int, StockItem> GetAllStockItems()
        {
            return StockItems;
        }
        public StockItem CreateStockItem(int code, string name, int quantityInStock)
        {
            StockItem item = FindStockItem(code);
            if (item == null) // means if does not already exists
            {
                item = new StockItem(code, name, quantityInStock);
                StockItems.Add(item.Code, item); // Issue with the code using ID - basically the dictionary does not accept object value to be as key of the dictionary
                return item;
            }
            throw new Exception("Item code "+code+" already exists. Item not added.");
        }
        public StockItem FindStockItem(int code)
        {
            StockItem item;
            if (StockItems.ContainsKey(code)) // Reading through the Dictionary (automated code)
            {
                return StockItems[code]; // return the value based on the key = code
            }
            else
            {
                item = null;
            }
            return item; // return product as null if not found
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
            StockItem item = FindStockItem(code);
            if(item == null)
            {
                throw new Exception("Stock item "+code+" not found. Quantity not removed.");
            }
            else
            {
                item.QuantityInStock -= quantityToRemove;
            }
            return item;
        }
        public StockItem DeleteStockItem(int code)
        {
            StockItem item = FindStockItem(code); // found the item
            if(item == null)
            {
                throw new Exception("Item has not been deleted because it cannot be found");
            }
            else if (item.QuantityInStock > 0)
            {
                throw new Exception("Item cannot be deleted because quantity in stock is not zero");
            }
            else
            {
                StockItems.Remove(code); // item code
            }
            return item;
        }
    }
}
