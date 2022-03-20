using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class ItemDeletedTransaction : Transaction
    {
        // Attributes
        public int StockItemCode { get; set; }
        public string StockItemName { get; set; }

        // Constructor
        public ItemDeletedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName) : base(null, transactionDateTime)
        {
            StockItemCode = stockItemCode;
            StockItemName = stockItemName;
            TransactionDatetime = transactionDateTime;
            TransactionName = "Item deleted";
        }

        public override string ToString()
        {
            return string.Format(
                TransactionDatetime.ToString("dd/MM/yyyy HH:mm") +
                " "+TransactionName+"     - Item "+StockItemCode+": "+StockItemName+" deleted."
            );
        }
    }
}
