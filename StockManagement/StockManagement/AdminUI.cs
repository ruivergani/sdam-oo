using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class AdminUI
    {
        public StockManager stockMgr { get; private set; }
        public TransactionManager transactionMgr { get; private set; }
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
                transactionMgr.RecordQuantityRemoved(new StockItem(item.Code, item.Name, item.QuantityInStock), quantityToRemove);
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
        // Based on StockManager Class
        public List<string> ViewStockLevels()
        {
            List<string> expectedResults = new List<string>();
            if (stockMgr.GetAllStockItems().Count > 0)
            {
                expectedResults.Add("\nStock Levels");
                expectedResults.Add("============");
                expectedResults.Add("Item code\tItem name\tQuantity in stock");
                foreach (StockItem item in stockMgr.StockItems.Values)
                {
                    expectedResults.Add(item.Code+"\t\t"+item.Name+"\t\t"+item.QuantityInStock);
                }
            }
            else
            {
                expectedResults.Add("\nStock Levels");
                expectedResults.Add("============");
                expectedResults.Add("No stock items");
            }
            return expectedResults;
        }
        public List<string> ViewTransactionLog()
        {
            List<string> expectedResults = new List<string>();
            if (transactionMgr.GetAllTransactions().Count > 0)
            {
                expectedResults.Add("\nTransaction log");
                expectedResults.Add("===============");
                foreach (Transaction item in transactionMgr.Transactions)
                {
                    expectedResults.Add(Convert.ToString(item));
                }
            }
            else
            {
                expectedResults.Add("\nTransaction log");
                expectedResults.Add("===============");
                expectedResults.Add("No transactions");
            }
            return expectedResults;
        }
    }
}
