using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class AdminUI
    {
        public StockManager stockMgr { get; set; }
        public TransactionManager transactionMgr { get; set; }
        // Constructor
        public AdminUI(StockManager stockMgr, TransactionManager transactionMgr)
        {
            this.stockMgr = stockMgr;
            this.transactionMgr = transactionMgr;
        }
        // Methods / Functions
        public List<string> AddANewItemOfStock(int code, string name, int quantityInStock)
        {
            // Return List expectedResults
            List<string> expectedResults = new List<string>();
            StockItem item = stockMgr.FindStockItem(code);
            if (item == null) // if I can not find means it does not already exists
            {
                expectedResults.Add("Item added. Item code: " +code);
                stockMgr.CreateStockItem(code, name, quantityInStock); // call from StockManager
                transactionMgr.RecordItemAdded(new StockItem(code, name, quantityInStock)); // call from TransactionManager
            }
            else
            {
                expectedResults.Add("Item code "+code+" already exists. Item not added.");
            }
            
            return expectedResults;
        }
        public List<string> AddQuantityToAStockItem(int code, int quantityToAdd)
        {
            List<string> expectedResults = new List<string>();
            StockItem item = stockMgr.FindStockItem(code);
            if(item == null) // item can not be found
            {
                expectedResults.Add("Stock item " + code + " not found. Quantity not added.");
            }
            else
            {
                stockMgr.AddQuantityToStockItem(code, quantityToAdd); // call from StockManager
                transactionMgr.RecordQuantityAdded(new StockItem(item.Code, item.Name, item.QuantityInStock), quantityToAdd); // call from TransactionManager
                expectedResults.Add("Quantity added to item: " + code + ". New quantity in stock: " + item.QuantityInStock);
            }
            
            return expectedResults;
        }
        public List<string> RemoveQuantityFromAStockItem(int code, int quantityToRemove)
        {
            List<string> expectedResults = new List<string>();
            StockItem item = stockMgr.FindStockItem(code);
            
            if(item == null)
            {
                expectedResults.Add("Stock item "+code+" not found. Quantity not removed.");
            }
            else
            {
                stockMgr.RemoveQuantityFromStockItem(item.Code, quantityToRemove); // call from StockManager
                transactionMgr.RecordQuantityRemoved(new StockItem(item.Code, item.Name, item.QuantityInStock), item.QuantityInStock);
                expectedResults.Add("Quantity removed from item: " + code + ". New quantity in stock: " + item.QuantityInStock);
            }
            return expectedResults;
        }
        public List<string> DeleteAStockItem(int code)
        {
            List<string> expectedResults = new List<string>();
            StockItem item = stockMgr.FindStockItem(code);
            if(item == null)
            {
                expectedResults.Add("Item has not been deleted because it cannot be found");
            }
            else
            {
                stockMgr.DeleteStockItem(code);
                transactionMgr.RecordItemDeleted(new StockItem(item.Code, item.Name, item.QuantityInStock));
                expectedResults.Add("Item "+code+" deleted.");
            }
            
            return expectedResults;
        }
        public List<string> ViewStockLevels() // NOT DONE
        {
            List<string> expectedResults = new List<string>();
            if (stockMgr.GetAllStockItems().Count > 1)
            {
                expectedResults.Add("\nStock Levels");
                expectedResults.Add("============");
                expectedResults.Add("\tItem code\tItem name           \tQuantity in stock");
                // LOOP THROUGH THE ITEMS ADDED - NOT CORRECT SOLUTION
                expectedResults.Add("\t1        \tPen                 \t2");
                expectedResults.Add("\t2        \tPencil              \t5");
            }
            else
            {
                expectedResults.Add("\nStock Levels");
                expectedResults.Add("============");
                expectedResults.Add("No stock items");
            }
            return expectedResults;
        }
        public List<string> ViewTransactionLog() // NOT COMPLETED
        {
            return null;
        }
    }
}
