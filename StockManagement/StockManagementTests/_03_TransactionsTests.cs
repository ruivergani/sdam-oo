using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagement;
using System;

namespace StockManagementTests
{
    [TestClass]
    public class _03_TransactionsTests
    {
        [TestMethod]
        public void _01_ItemAddedTransaction_has_correct_date_and_time()
        {
            DateTime now = DateTime.Now;
            Transaction t = new ItemAddedTransaction(now, 1, "Pen", 1);
            Assert.AreEqual(now, t.TransactionDatetime);
        }

        [TestMethod]
        public void _02_ItemAddedTransaction_has_correct_transaction_name()
        {
            DateTime now = DateTime.Now;
            Transaction t = new ItemAddedTransaction(now, 1, "Pen", 1);
            Assert.AreEqual("Item added", t.TransactionName);
        }

        [TestMethod]
        public void _03_ToString_in_ItemAddedTransaction_returns_correct_string()
        {
            DateTime now = DateTime.Now;
            string dateStr = now.ToString("dd/MM/yyyy HH:mm");
            Transaction t = new ItemAddedTransaction(now, 1, "Pen", 2);

            Assert.AreEqual(
                dateStr + " Item added       - Item 1: Pen added. Quantity in stock: 2",
                t.ToString());
        }

        [TestMethod]
        public void _04_ItemDeletedTransaction_has_correct_date_and_time()
        {
            DateTime now = DateTime.Now;
            Transaction t = new ItemDeletedTransaction(now, 1, "Pen");
            Assert.AreEqual(now, t.TransactionDatetime);
        }

        [TestMethod]
        public void _05_ItemDeletedTransaction_has_correct_transaction_name()
        {
            DateTime now = DateTime.Now;
            Transaction t = new ItemDeletedTransaction(now, 1, "Pen");
            Assert.AreEqual("Item deleted", t.TransactionName);
        }

        [TestMethod]
        public void _06_ToString_in_ItemDeletedTransaction_returns_correct_string()
        {
            DateTime now = DateTime.Now;
            string dateStr = now.ToString("dd/MM/yyyy HH:mm");
            Transaction t = new ItemDeletedTransaction(now, 1, "Pen");

            Assert.AreEqual(
                dateStr + " Item deleted     - Item 1: Pen deleted.",
                t.ToString());
        }

        [TestMethod]
        public void _07_QuantityAddedTransaction_has_correct_date_and_time()
        {
            DateTime now = DateTime.Now;
            Transaction t = new QuantityAddedTransaction(now, 1, "Pen", 3, 6);
            Assert.AreEqual(now, t.TransactionDatetime);
        }

        [TestMethod]
        public void _08_QuantityAddedTransaction_has_correct_transaction_name()
        {
            DateTime now = DateTime.Now;
            Transaction t = new QuantityAddedTransaction(now, 1, "Pen", 3, 6);
            Assert.AreEqual("Quantity added", t.TransactionName);
        }

        [TestMethod]
        public void _09_ToString_in_QuantityAddedTransaction_returns_correct_string()
        {
            DateTime now = DateTime.Now;
            string dateStr = now.ToString("dd/MM/yyyy HH:mm");
            Transaction t = new QuantityAddedTransaction(now, 1, "Pen", 3, 6);

            Assert.AreEqual(
                dateStr + " Quantity added   - Item 1: Pen. Quantity added: 3. New quantity in stock: 6",
                t.ToString());
        }

        [TestMethod]
        public void _10_QuantityRemovedTransaction_has_correct_date_and_time()
        {
            DateTime now = DateTime.Now;
            Transaction t = new QuantityRemovedTransaction(now, 1, "Pen", 3, 6);
            Assert.AreEqual(now, t.TransactionDatetime);
        }

        [TestMethod]
        public void _11_QuantityRemovedTransaction_has_correct_transaction_name()
        {
            DateTime now = DateTime.Now;
            Transaction t = new QuantityRemovedTransaction(now, 1, "Pen", 3, 6);
            Assert.AreEqual("Quantity removed", t.TransactionName);
        }

        [TestMethod]
        public void _12_ToString_in_QuantityRemovedTransaction_returns_correct_string()
        {
            DateTime now = DateTime.Now;
            string dateStr = now.ToString("dd/MM/yyyy HH:mm");
            Transaction t = new QuantityRemovedTransaction(now, 1, "Pen", 2, 8);

            Console.WriteLine("\n" + dateStr + " Quantity removed - Item 1: Pen. Quantity removed: 2. New quantity in stock: 8");
            Console.WriteLine(t.ToString());

            Assert.AreEqual(
                dateStr + " Quantity removed - Item 1: Pen. Quantity removed: 2. New quantity in stock: 8",
                t.ToString());
        }
    }
}
