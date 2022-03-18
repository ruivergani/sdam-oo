using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManagement;
using System;

namespace StockManagementTests
{
    [TestClass]
    public class _01_StockItemTests
    {
        [TestMethod]
        public void _01_New_stock_item_has_correct_code()
        {
            StockItem item = new StockItem(1, "Pen", 12);
            Assert.AreEqual(1, item.Code);
        }

        //[TestMethod]
        //public void _02_New_stock_item_has_correct_name()
        //{
        //    StockItem item = new StockItem(1, "Pencil", 12);
        //    Assert.AreEqual("Pencil", item.Name);
        //}

        //[TestMethod]
        //public void _03_New_stock_item_has_correct_quantity()
        //{
        //    StockItem item = new StockItem(1, "Pen", 2);
        //    Assert.AreEqual(2, item.QuantityInStock);
        //}

        //[TestMethod]
        //public void _04_New_stock_item_still_has_correct_quantity()
        //{
        //    StockItem item = new StockItem(1, "Pen", 32);
        //    Assert.AreEqual(32, item.QuantityInStock);
        //}

        //[TestMethod]
        //public void _05_New_stock_item_with_non_positive_code_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(-2, "Paper", 500);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item code must be a positive integer. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _06_New_stock_item_with_empty_name_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(10, "", 50);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item name cannot be blank. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _07_New_stock_item_with_just_spaces_for_name_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(10, "    ", 50);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item name cannot be just spaces. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _08_New_stock_item_with_non_positive_quantity_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(1, "Paper", -23);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Quantity cannot be zero or negative. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _09_New_stock_item_with_multiple_errors_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(-2, "", -3);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item code must be a positive integer. Item name cannot be blank. Quantity cannot be zero or negative. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _10_New_stock_item_with_multiple_errors_has_correct_exception_message()
        //{
        //    try
        //    {
        //        new StockItem(-12, "   ", 13);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Item code must be a positive integer. Item name cannot be just spaces. ", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _11_Adding_quantity_to_stock_item_increases_quantity_in_stock()
        //{
        //    StockItem item = new StockItem(1, "Pencil", 12);
        //    item.AddQuantity(13);
        //    Assert.AreEqual(25, item.QuantityInStock);
        //}

        //[TestMethod]
        //public void _12_Adding_non_positive_quantity_to_stock_item_has_correct_exception_message()
        //{
        //    try
        //    {
        //        StockItem item = new StockItem(1, "Pencil", 12);
        //        item.AddQuantity(-13);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Quantity cannot be negative", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _13_Adding_non_positive_quantity_to_stock_item_does_not_change_quantity_in_stock()
        //{
        //    StockItem item = new StockItem(1, "Pencil", 12);
        //    try
        //    {
        //        item.AddQuantity(-13);
        //    }
        //    catch (Exception)
        //    {
        //        Assert.AreEqual(12, item.QuantityInStock);
        //    }
        //}

        //[TestMethod]
        //public void _14_Removing_quantity_from_stock_item_decreases_quantity_in_stock()
        //{
        //    StockItem item = new StockItem(1, "Pencil", 12);
        //    item.SubtractQuantity(10);
        //    Assert.AreEqual(2, item.QuantityInStock);
        //}

        //[TestMethod]
        //public void _15_Removing_non_positive_quantity_from_stock_item_has_correct_exception_message()
        //{
        //    try
        //    {
        //        StockItem item = new StockItem(1, "Pencil", 12);
        //        item.SubtractQuantity(-13);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Quantity cannot be negative", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _16_Removing_non_positive_quantity_from_stock_item_does_not_change_quantity_in_stock()
        //{
        //    StockItem item = new StockItem(1, "Pencil", 12);
        //    try
        //    {
        //        item.SubtractQuantity(-13);
        //    }
        //    catch (Exception)
        //    {
        //        Assert.AreEqual(12, item.QuantityInStock);
        //    }
        //}

        //[TestMethod]
        //public void _17_All_quantity_in_stock_can_be_removed_from_stock_item()
        //{
        //    StockItem item = new StockItem(1, "Protractor", 5);
        //    item.SubtractQuantity(5);
        //    Assert.AreEqual(0, item.QuantityInStock);
        //}

        //[TestMethod]
        //public void _18_Removing_too_much_quantity_from_stock_item_has_correct_exception_message()
        //{
        //    try
        //    {
        //        StockItem item = new StockItem(1, "Set square", 3);
        //        item.SubtractQuantity(13);
        //        Assert.Fail("Exception not thrown");
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("Insufficient quantity in stock", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void _19_Removing_too_much_quantity_from_stock_item_does_not_change_quantity_in_stock()
        //{
        //    StockItem item = new StockItem(1, "Set square", 3);
        //    try
        //    {
        //        item.SubtractQuantity(8);
        //    }
        //    catch (Exception)
        //    {
        //        Assert.AreEqual(3, item.QuantityInStock);
        //    }
        //}
    }
}
