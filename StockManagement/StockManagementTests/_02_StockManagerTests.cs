using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagement;
using System;
using System.Collections.Generic;

namespace StockManagementTests
{
    [TestClass]
    public class _02_StockManagerTests
    {
        //[TestMethod]
        //public void _01_GetAllStockItems_does_not_return_null()
        //{
        //    Assert.IsNotNull(new StockManager().GetAllStockItems());
        //}

        //[TestMethod]
        //public void _02_GetAllStockItems_returns_a_sorted_dictonary()
        //{
        //    Assert.IsInstanceOfType(
        //        new StockManager().GetAllStockItems(), 
        //        typeof(SortedDictionary<int, StockItem>));
        //}

        //[TestMethod]
        //public void _03_CreateStockItem_adds_a_new_StockItem_to_its_SortedDictionary()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);

        //    Assert.AreEqual(2, mgr.GetAllStockItems().Count);
        //}

        //[TestMethod]
        //public void _04_CreateStockItem_returns_a_StockItem()
        //{
        //    Assert.IsInstanceOfType(
        //        new StockManager().CreateStockItem(1, "Pen", 2),
        //        typeof(StockItem));
        //}

        //[TestMethod]
        //public void _05_FindStockItem_returns_an_existing_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    Assert.AreEqual("Pen", mgr.FindStockItem(1).Name);
        //}

        //[TestMethod]
        //public void _06_FindStockItem_returns_null_if_StockItem_does_not_exist()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    Assert.IsNull(mgr.FindStockItem(11));
        //}

        //[TestMethod]
        //public void _07_Creating_an_existing_StockItem_throws_an_exception()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    Assert.ThrowsException<Exception>(
        //        () => mgr.CreateStockItem(1, "Pen", 2));
        //}

        //[TestMethod]
        //public void _08_Creating_an_existing_StockItem_has_correct_exception_message()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(5, "Pen holder", 2);
        //    try
        //    {
        //        mgr.CreateStockItem(5, "Pen holder", 2);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item code 5 already exists. Item not added.", e.Message);

        //    }
        //}

        //[TestMethod]
        //public void _09_AddQuantityToStockItem_updates_the_correct_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    mgr.AddQuantityToStockItem(2, 3);

        //    Assert.AreEqual(8, mgr.FindStockItem(2).QuantityInStock);
        //}

        //[TestMethod]
        //public void _10_AddQuantityToStockItem_returns_the_correct_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.AreEqual(2, mgr.AddQuantityToStockItem(2, 3).Code);
        //}

        //[TestMethod]
        //public void _11_Adding_quantity_to_a_non_existing_StockItem_throws_an_exception()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.ThrowsException<Exception>(
        //        () => mgr.AddQuantityToStockItem(4, 3));
        //}

        //[TestMethod]
        //public void _12_Adding_quantity_to_a_non_existing_StockItem_has_correct_exception_message()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    try
        //    {
        //        mgr.AddQuantityToStockItem(23, 2);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Stock item 23 not found. Quantity not added.", e.Message);

        //    }
        //}

        //[TestMethod]
        //public void _13_RemoveQuantityStockItem_updates_the_correct_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    mgr.RemoveQuantityFromStockItem(3, 4);

        //    Assert.AreEqual(11, mgr.FindStockItem(3).QuantityInStock);
        //}

        //[TestMethod]
        //public void _14_RemoveQuantityStockItem_returns_the_correct_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.AreEqual(3, mgr.RemoveQuantityFromStockItem(3, 4).Code);
        //}

        //[TestMethod]
        //public void _15_Removing_quantity_from_a_non_existing_StockItem_throws_an_exception()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.ThrowsException<Exception>(
        //        () => mgr.RemoveQuantityFromStockItem(14, 31));
        //}

        //[TestMethod]
        //public void _16_Removing_quantity_from_a_non_existing_StockItem_has_correct_exception_message()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    try
        //    {
        //        mgr.RemoveQuantityFromStockItem(243, 22);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Stock item 243 not found. Quantity not removed.", e.Message);

        //    }
        //}

        //[TestMethod]
        //public void _17_DeleteStockItem_removes_a_StockItem_from_its_SortedDictionary()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);

        //    mgr.RemoveQuantityFromStockItem(1, 2);
        //    mgr.DeleteStockItem(1);

        //    Assert.AreEqual(1, mgr.GetAllStockItems().Count);
        //}

        //[TestMethod]
        //public void _18_DeleteStockItem_returns_a_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);

        //    mgr.RemoveQuantityFromStockItem(1, 2);

        //    Assert.IsInstanceOfType(
        //        mgr.DeleteStockItem(1),
        //        typeof(StockItem));
        //}

        //[TestMethod]
        //public void _19_DeleteStockItem_deletes_the_correct_StockItem()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);
        //    mgr.CreateStockItem(4, "Pencil case", 45);


        //    mgr.RemoveQuantityFromStockItem(3, 15);
        //    mgr.DeleteStockItem(3);

        //    Assert.IsNull(mgr.FindStockItem(3));
        //}

        //[TestMethod]
        //public void _20_Deleting_a_non_existing_StockItem_throws_an_exception()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.ThrowsException<Exception>(
        //        () => mgr.DeleteStockItem(14));
        //}

        //[TestMethod]
        //public void _21_Deleting_a_non_existing_StockItem_has_correct_exception_message()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    try
        //    {
        //        mgr.DeleteStockItem(243);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item has not been deleted because it cannot be found", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _22_Deleting_a_StockItem_with_quantity_in_stock_greater_than_zero_throws_an_exception()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    Assert.ThrowsException<Exception>(
        //        () => mgr.DeleteStockItem(3));
        //}

        //[TestMethod]
        //public void _23_Deleting_a_StockItem_with_quantity_in_stock_greater_than_zero_has_correct_exception_message()
        //{
        //    StockManager mgr = new StockManager();
        //    mgr.CreateStockItem(1, "Pen", 2);
        //    mgr.CreateStockItem(2, "Pencil", 5);
        //    mgr.CreateStockItem(3, "Protractor", 15);

        //    try
        //    {
        //        mgr.DeleteStockItem(1);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item cannot be deleted because quantity in stock is not zero", e.Message);
        //    }
        //}
    }
}
