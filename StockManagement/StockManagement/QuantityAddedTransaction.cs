using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class QuantityAddedTransaction : Transaction
    {
        // Attributes
        public int StockItemCode { get; set; }
        public string StockItemName { get; set; }
        public int QuantityAdded { get; set; }
        public int NewQuantityInStock { get; set; }

        // Constructor
        public QuantityAddedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityAdded, int newQuantityInStock) : base(null, transactionDateTime)
        {
            TransactionDatetime = transactionDateTime;
            StockItemCode = stockItemCode;
            StockItemName = stockItemName;
            QuantityAdded = quantityAdded;
            NewQuantityInStock = newQuantityInStock;
            TransactionName = "Quantity added";
        }

        public override string ToString()
        {
            return string.Format(
                TransactionDatetime.ToString("dd/MM/yyyy HH:mm") +
                " "+TransactionName+"   - Item "+StockItemCode+": "+StockItemName+". Quantity added: "+QuantityAdded+". New quantity in stock: "+NewQuantityInStock);
        }
    }
}
