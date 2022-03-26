using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagement;
using System.Collections.Generic;

namespace StockManagementTests
{
    [TestClass]
    public class _04_TransactionManagerTests
    {
        [TestMethod]
        public void _01_GetAllTransactions_does_not_return_null()
        {
            Assert.IsNotNull(new TransactionManager().GetAllTransactions());
        }

        [TestMethod]
        public void _02_GetAllTransactions_returns_a_list()
        {
            Assert.IsInstanceOfType(
                new TransactionManager().GetAllTransactions(),
                typeof(List<Transaction>));
        }

        [TestMethod]
        public void _03_RecordItemAdded_adds_a_new_ItemAddedTransaction_to_its_List()
        {
            TransactionManager mgr = new TransactionManager();
            mgr.RecordItemAdded(new StockItem(1, "Pen", 2));

            Assert.IsInstanceOfType(
                mgr.GetAllTransactions()[0],
                typeof(ItemAddedTransaction));
        }

        [TestMethod]
        public void _04_RecordItemDeleted_adds_a_new_ItemDeletedTransaction_to_its_List()
        {
            TransactionManager mgr = new TransactionManager();
            mgr.RecordItemDeleted(new StockItem(1, "Pen", 2));

            Assert.IsInstanceOfType(
                mgr.GetAllTransactions()[0],
                typeof(ItemDeletedTransaction));
        }

        [TestMethod]
        public void _05_RecordQuantityAdded_adds_a_new_QuantityAddedTransaction_to_its_List()
        {
            TransactionManager mgr = new TransactionManager();
            mgr.RecordQuantityAdded(new StockItem(1, "Pen", 2), 4);

            Assert.IsInstanceOfType(
                mgr.GetAllTransactions()[0],
                typeof(QuantityAddedTransaction));
        }

        [TestMethod]
        public void _06_RecordQuantityRemoved_adds_a_new_QuantityRemovedTransaction_to_its_List()
        {
            TransactionManager mgr = new TransactionManager();
            mgr.RecordQuantityRemoved(new StockItem(1, "Pen", 3), 5);

            Assert.IsInstanceOfType(
                mgr.GetAllTransactions()[0],
                typeof(QuantityRemovedTransaction));
        }
    }
}
