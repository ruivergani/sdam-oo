using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class StockManager
    {

        //Attributes
        SortedDictionary<int, StockItem> StockItems { get; set; }
        private static int nextId = 0;
        public int Id { get; set; }

        public  StockManager()
        {
            Id = nextId; // Set value to 0
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
                StockItems.Add(Id, item);
                Id++;
            }
            else
            {
                throw new Exception("Item code "+code+" already exists. Item not added.");
            }
            return item;
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
                StockItems.Remove(item.Code);
                item = FindStockItem(code);
            }
            return item;
        }
    }
}
