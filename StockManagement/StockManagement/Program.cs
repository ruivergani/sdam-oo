using System;
using System.Collections.Generic;

namespace StockManagement
{
    public class Program
    {
        private const int ADD_NEW_ITEM_OF_STOCK = 1;
        private const int ADD_QUANTITY_TO_STOCK_ITEM = 2;
        private const int DELETE_STOCK_ITEM = 3;
        private const int DELETE_QUANTITY_FROM_STOCK_ITEM = 4;
        private const int VIEW_STOCK_LEVELS = 5;
        private const int VIEW_TRANSACTION_LOG = 6;
        private const int EXIT = 7;

        private static readonly StockManager stockMgr = new StockManager();
        private static readonly TransactionManager transactionMgr = new TransactionManager();
        static readonly AdminUI adminUI = new AdminUI(stockMgr, transactionMgr);

        public static void Main(string[] args)
        {
            DisplayMenu();
            int choice = ReadInteger("Option");
            while (choice != EXIT)
            {
                switch (choice)
                {
                    case ADD_NEW_ITEM_OF_STOCK:
                        AddANewItemOfStock();
                        break;
                    case ADD_QUANTITY_TO_STOCK_ITEM:
                        AddQuantityToAStockItem();
                        break;
                    case DELETE_STOCK_ITEM:
                        DeleteAStockItem();
                        break;
                    case DELETE_QUANTITY_FROM_STOCK_ITEM:
                        RemoveQuantityFromAStockItem();
                        break;
                    case VIEW_STOCK_LEVELS:
                        ViewStockLevels();
                        break;
                    case VIEW_TRANSACTION_LOG:
                        ViewTransactionLog();
                        break;
                    default:
                        Console.WriteLine("\nERROR: Option not recognised. Please try again.");
                        break;
                }
                DisplayMenu();
                choice = ReadInteger("Option");
            }

        }
        // Functions
        private static void DisplayMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine(ADD_NEW_ITEM_OF_STOCK + " - Add a new item of stock");
            Console.WriteLine(ADD_QUANTITY_TO_STOCK_ITEM + " - Add quantity to stock item");
            Console.WriteLine(DELETE_STOCK_ITEM + " - Delete stock item");
            Console.WriteLine(DELETE_QUANTITY_FROM_STOCK_ITEM + " - Delete quantity from stock item");
            Console.WriteLine(VIEW_STOCK_LEVELS + " - View Stock Levels");
            Console.WriteLine(VIEW_TRANSACTION_LOG + " - View Transaction Log");
            Console.WriteLine(EXIT + " - Exit");
            Console.WriteLine("\n"); 
        }
        private static int ReadInteger(string prompt)
        {
            try
            {
                Console.Write(prompt + ": > ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private static string ReadString(string prompt)
        {
            // ideal should be validating the string for only letters (not numbers)
            Console.Write(prompt + ": > ");
            return Convert.ToString(Console.ReadLine());
        }
        public static void DisplayResults(List<string> results)
        {
           
        }
        public static void AddANewItemOfStock()
        {
            int code = ReadInteger("\nCode");
            string name = ReadString("Name");
            int quantityStock = ReadInteger("Quantity in Stock");
            try
            {
                adminUI.AddANewItemOfStock(code, name, quantityStock);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }
        }
        public static void AddQuantityToAStockItem()
        {
            int code = ReadInteger("\nCode");
            int quantityToAdd = ReadInteger("Quantity To Add");
            try
            {
                adminUI.AddQuantityToAStockItem(code, quantityToAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }
        }
        public static void DeleteAStockItem()
        {
            int code = ReadInteger("\nCode");
            try
            {
                adminUI.DeleteAStockItem(code);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }
        }
        public static void RemoveQuantityFromAStockItem()
        {
            int code = ReadInteger("\nCode");
            int quantityToRemove = ReadInteger("Quantity To Remove");
            try
            {
                adminUI.RemoveQuantityFromAStockItem(code, quantityToRemove);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }
        }
        public static void ViewTransactionLog()
        {
            adminUI.ViewTransactionLog();
        }
        public static void ViewStockLevels()
        {
            adminUI.ViewStockLevels();
        }
        
    }
}
