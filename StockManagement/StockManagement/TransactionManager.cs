using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class  TransactionManager
    {
        // Attributes 
        public List<Transaction> Transactions = new List<Transaction>();
        

        // Methods
        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> listTransaction = new List<Transaction>();
            return listTransaction;
        }
        public void RecordItemAdded(StockItem stockItem)
        {
            // NOT WORKING CODE
        }
        public void RecordItemDeleted(StockItem stockItem)
        {
            // NOT WORKING CODE
        }
        public void RecordQuantityAdded(StockItem stockItem, int quantityAdded)
        {
            // NOT WORKING CODE
        }
        public void RecordQuantityRemoved(StockItem stockItem, int quantityRemoved)
        {
            // NOT WORKING CODE
        }
    }
}
