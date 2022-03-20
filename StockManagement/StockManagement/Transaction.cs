using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public abstract class Transaction
    {
        // Attributes - fields
        public DateTime TransactionDatetime { get; set; }
        public string TransactionName { get; set; }
        public Transaction(string name, DateTime dt)
        {
            TransactionName = name;
            TransactionDatetime = dt;
        }

        public abstract override string ToString(); // convert the values to string
        
    }
}
