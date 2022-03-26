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
    }
}
