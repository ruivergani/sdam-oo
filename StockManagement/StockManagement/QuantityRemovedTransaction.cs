using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class QuantityRemovedTransaction : Transaction
    {
        // Attributes
        public int StockItemCode { get; set; }
        public string StockItemName { get; set; }
        public int QuantityRemoved { get; set; }
        public int NewQuantityInStock { get; set; }

        // Constructor
        public QuantityRemovedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityRemoved, int newQuantityInStock) : base(null, transactionDateTime)
        {
            TransactionDatetime = transactionDateTime;
            StockItemCode = stockItemCode;
            StockItemName = stockItemName;
            QuantityRemoved = quantityRemoved;
            NewQuantityInStock = newQuantityInStock;
            TransactionName = "Quantity removed";
        }

        public override string ToString()
        {
            return string.Format(
                TransactionDatetime.ToString("dd/MM/yyyy HH:mm") +
                " "+TransactionName+" - Item "+StockItemCode+": "+StockItemName+". Quantity removed: "+QuantityRemoved+". New quantity in stock: "+NewQuantityInStock);
        }
    }
}
