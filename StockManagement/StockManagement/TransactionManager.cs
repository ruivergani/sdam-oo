using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManagement
{
    public class  TransactionManager
    {
        // Attributes 
        public List<Transaction> Transactions { get; set; }
        public List<ItemAddedTransaction> ItemAdded { get; set; }

        
        // Constructor Empty
        public TransactionManager()
        {
            Transactions = new List<Transaction>();
        }

        // Methods
        public List<Transaction> GetAllTransactions()
        {
            return Transactions;
        }
        public void RecordItemAdded(StockItem stockItem)
        {
            Transactions.Add(new ItemAddedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, stockItem.QuantityInStock));
        }
        public void RecordItemDeleted(StockItem stockItem)
        {
            Transactions.Add(new ItemDeletedTransaction(DateTime.Now, stockItem.Code, stockItem.Name));
        }
        public void RecordQuantityAdded(StockItem stockItem, int quantityAdded)
        {
            Transactions.Add(new QuantityAddedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, quantityAdded, stockItem.QuantityInStock));
        }
        public void RecordQuantityRemoved(StockItem stockItem, int quantityRemoved)
        {
            Transactions.Add(new QuantityRemovedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, quantityRemoved, stockItem.QuantityInStock));
        }
    }
}
