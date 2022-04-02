using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class ItemAddedTransaction : Transaction
    {

        // Attributes
        public int StockItemCode { get; set; }
        public string StockItemName { get; set; }
        public int QuantityAdded { get; set; }
        
        // Constructor
        public ItemAddedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityAdded) : base(null,transactionDateTime)
        {
            StockItemCode = stockItemCode;
            StockItemName = stockItemName;
            QuantityAdded = quantityAdded;
            TransactionDatetime = transactionDateTime;
            TransactionName = "Item added";
        }

        public override string ToString()
        {
            return string.Format(TransactionDatetime.ToString("dd/MM/yyyy HH:mm")+" "+TransactionName+ "       - Item " + StockItemCode+": "+StockItemName+" added. Quantity in stock: "+QuantityAdded);
        }
    }
}
