using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagement;
using System.Collections.Generic;

namespace StockManagementTests
{
    [TestClass]
    public class _05_AdminUITests
    {
        //[TestMethod]
        //public void _01_AddANewItemOfStock_calls_CreateStockItem_in_stock_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    ui.AddANewItemOfStock(1, "Pen", 2);
        //    Assert.AreEqual(1, stockMgr.GetAllStockItems().Count);
        //}

        //[TestMethod]
        //public void _02_AddANewItemOfStock_calls_RecordItemAdded_in_transaction_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    ui.AddANewItemOfStock(1, "Pen", 2);

        //    Assert.IsInstanceOfType(
        //        tMgr.GetAllTransactions()[0],
        //        typeof(ItemAddedTransaction));
        //}

        //[TestMethod]
        //public void _03_AddANewItemOfStock_returns_correct_results_list_when_stock_item_is_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Item added. Item code: 1");

        //    CollectionAssert.AreEqual(expectedResults, ui.AddANewItemOfStock(1, "Pen", 2));
        //}

        //[TestMethod]
        //public void _04_AddANewItemOfStock_returns_correct_results_list_when_existing_stock_item_is_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);
        //    ui.AddANewItemOfStock(1, "Pen", 2);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Item code 1 already exists. Item not added.");

        //    CollectionAssert.AreEqual(expectedResults, ui.AddANewItemOfStock(1, "Pen", 2));
        //}

        //[TestMethod]
        //public void _05_AddQuantityToAStockItem_calls_AddQuantityToStockItem_in_stock_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    ui.AddQuantityToAStockItem(1, 4);

        //    Assert.AreEqual(6, stockMgr.GetAllStockItems()[1].QuantityInStock);
        //}

        //[TestMethod]
        //public void _06_AddQuantityToAStockItem_calls_RecordQuantityAdded_in_transaction_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    ui.AddQuantityToAStockItem(1, 9);

        //    Assert.IsInstanceOfType(
        //        tMgr.GetAllTransactions()[0],
        //        typeof(QuantityAddedTransaction));
        //}

        //[TestMethod]
        //public void _07_AddQuantityToAStockItem_returns_correct_results_list_when_stock_item_is_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Quantity added to item: 1. New quantity in stock: 14");

        //    CollectionAssert.AreEqual(expectedResults, ui.AddQuantityToAStockItem(1, 12));
        //}

        //[TestMethod]
        //public void _08_AddQuantityToAStockItem_returns_correct_results_list_when_stock_item_is_not_found()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Stock item 1 not found. Quantity not added.");

        //    CollectionAssert.AreEqual(expectedResults, ui.AddQuantityToAStockItem(1, 9));
        //}

        //[TestMethod]
        //public void _09_RemoveQuantityFromAStockItem_calls_RemoveQuantityFromStockItem_in_stock_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 12);
        //    ui.RemoveQuantityFromAStockItem(1, 4);

        //    Assert.AreEqual(8, stockMgr.GetAllStockItems()[1].QuantityInStock);
        //}

        //[TestMethod]
        //public void _10_RemoveQuantityFromAStockItem_calls_RecordQuantityRemoved_in_transaction_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 9);
        //    ui.RemoveQuantityFromAStockItem(1, 8);

        //    Assert.IsInstanceOfType(
        //        tMgr.GetAllTransactions()[0],
        //        typeof(QuantityRemovedTransaction));
        //}

        //[TestMethod]
        //public void _11_RemoveQuantityFromAStockItem_returns_correct_results_list_when_stock_item_is_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 22);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Quantity removed from item: 1. New quantity in stock: 0");

        //    CollectionAssert.AreEqual(expectedResults, ui.RemoveQuantityFromAStockItem(1, 22));
        //}

        //[TestMethod]
        //public void _12_RemoveQuantityFromAStockItem_returns_correct_results_list_when_stock_item_is_not_found()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Stock item 1 not found. Quantity not removed.");

        //    CollectionAssert.AreEqual(expectedResults, ui.RemoveQuantityFromAStockItem(1, 4));
        //}

        //[TestMethod]
        //public void _13_DeleteAStockItem_calls_DeleteStockItem_in_stock_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    stockMgr.RemoveQuantityFromStockItem(1, 2);
        //    ui.DeleteAStockItem(1);
        //    Assert.AreEqual(0, stockMgr.GetAllStockItems().Count);
        //}

        //[TestMethod]
        //public void _14_DeleteAStockItem_calls_RecordItemDeleted_in_transaction_manager()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    stockMgr.RemoveQuantityFromStockItem(1, 2);
        //    ui.DeleteAStockItem(1);

        //    Assert.IsInstanceOfType(
        //        tMgr.GetAllTransactions()[0],
        //        typeof(ItemDeletedTransaction));
        //}

        //[TestMethod]
        //public void _15_DeleteAStockItem_returns_correct_results_list_when_stock_item_is_deleted()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    stockMgr.RemoveQuantityFromStockItem(1, 2);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Item 1 deleted.");

        //    CollectionAssert.AreEqual(expectedResults, ui.DeleteAStockItem(1));
        //}

        //[TestMethod]
        //public void _16_DeleteAStockItem_returns_correct_results_list_when_non_existent_stock_item_is_deleted()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("Item has not been deleted because it cannot be found");

        //    CollectionAssert.AreEqual(expectedResults, ui.DeleteAStockItem(1));
        //}

        //[TestMethod]
        //public void _17_ViewStockLevels_returns_correct_results_list_when_stock_item_has_been_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    stockMgr.CreateStockItem(1, "Pen", 2);
        //    stockMgr.CreateStockItem(2, "Pencil", 5);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("\nStock Levels");
        //    expectedResults.Add("============");
        //    expectedResults.Add("\tItem code\tItem name           \tQuantity in stock");
        //    expectedResults.Add("\t1        \tPen                 \t2");
        //    expectedResults.Add("\t2        \tPencil              \t5");

        //    CollectionAssert.AreEqual(expectedResults, ui.ViewStockLevels());
        //}

        //[TestMethod]
        //public void _18_ViewStockLevels_returns_correct_results_list_when_no_stock_items_have_been_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("\nStock Levels");
        //    expectedResults.Add("============");
        //    expectedResults.Add("No stock items");

        //    CollectionAssert.AreEqual(expectedResults, ui.ViewStockLevels());
        //}

        //[TestMethod]
        //public void _19_ViewTransactionLog_returns_correct_results_list_when_transactions_have_been_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    ui.AddANewItemOfStock(1, "Pen", 2);
        //    ui.AddQuantityToAStockItem(1, 3);
        //    ui.RemoveQuantityFromAStockItem(1, 5);
        //    ui.DeleteAStockItem(1);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("\nTransaction log");
        //    expectedResults.Add("===============");
        //    expectedResults.Add(
        //        tMgr.GetAllTransactions()[0].TransactionDatetime.ToString("dd/MM/yyyy HH:mm") 
        //        + " Item added       - Item 1: Pen added. Quantity in stock: 2");
        //    expectedResults.Add(
        //        tMgr.GetAllTransactions()[1].TransactionDatetime.ToString("dd/MM/yyyy HH:mm") 
        //        + " Quantity added   - Item 1: Pen. Quantity added: 3. New quantity in stock: 5");
        //    expectedResults.Add(
        //        tMgr.GetAllTransactions()[2].TransactionDatetime.ToString("dd/MM/yyyy HH:mm") 
        //        + " Quantity removed - Item 1: Pen. Quantity removed: 5. New quantity in stock: 0");
        //    expectedResults.Add(
        //        tMgr.GetAllTransactions()[3].TransactionDatetime.ToString("dd/MM/yyyy HH:mm") 
        //        + " Item deleted     - Item 1: Pen deleted.");

        //    CollectionAssert.AreEqual(expectedResults, ui.ViewTransactionLog());
        //}

        //[TestMethod]
        //public void _20_ViewTransaction_returns_correct_results_list_when_no_transactions_have_been_added()
        //{
        //    StockManager stockMgr = new StockManager();
        //    TransactionManager tMgr = new TransactionManager();
        //    AdminUI ui = new AdminUI(stockMgr, tMgr);

        //    List<string> expectedResults = new List<string>(1);
        //    expectedResults.Add("\nTransaction log");
        //    expectedResults.Add("===============");
        //    expectedResults.Add("No transactions");

        //    CollectionAssert.AreEqual(expectedResults, ui.ViewTransactionLog());
        //}
    }
}
