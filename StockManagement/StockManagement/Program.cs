﻿using System;

namespace StockManagement
{
    public class Program
    {
        private const int VIEW_TRANSACTION_LOG = 1;
        private const int VIEW_STOCK_LEVELS = 2;
        private const int ADD_NEW_ITEM_OF_STOCK = 3;
        private const int ADD_QUANTITY_TO_STOCK_ITEM = 4;
        private const int DELETE_STOCK_ITEM = 5;
        private const int DELETE_QUANTITY_FROM_STOCK_ITEM = 6;
        private const int EXIT = 7;

       // private static readonly AdminUI admin = new AdminUI();

        static void Main(string[] args)
        {
            DisplayMenu();
            int choice = ReadInteger("Option: > ");
            while (choice != EXIT)
            {
                switch (choice)
                {
                    case VIEW_TRANSACTION_LOG:
                        ViewTransactionLog();
                        break;
                    case VIEW_STOCK_LEVELS:
                        ViewStockLevels();
                        break;
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
                    default:
                        Console.WriteLine("\nERROR: Option not recognised. Please try again.");
                        break;
                }
                DisplayMenu();
                choice = ReadInteger("Option: > ");
            }

        }
        // Functions
        private static void DisplayMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine(VIEW_TRANSACTION_LOG + " .View Transaction Log");
            Console.WriteLine(VIEW_STOCK_LEVELS + " .View Stock Levels");
            Console.WriteLine(ADD_NEW_ITEM_OF_STOCK + " .Add a new item of stock");
            Console.WriteLine(ADD_QUANTITY_TO_STOCK_ITEM + " .Add quantity to stock item");
            Console.WriteLine(DELETE_STOCK_ITEM + " .Delete stock item");
            Console.WriteLine(DELETE_QUANTITY_FROM_STOCK_ITEM + " .Delete quantity from stock item");
            Console.WriteLine(EXIT + " .Exit");
            Console.WriteLine("\n"); 
        }
        private static int ReadInteger(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
        private static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToString(Console.ReadLine());
        }

        public static void AddANewItemOfStock()
        {
            // add new item of stock
        }
        public static void AddQuantityToAStockItem()
        {
            // add quantity to stock item
        }
        public static void DeleteAStockItem()
        {
            // delete a stock Item
        }
        public static void RemoveQuantityFromAStockItem()
        {
            // remove quantity from stock item
        }
        public static void ViewStockLevels()
        {
            // view stock levels
        }
        public static void ViewTransactionLog()
        {
            // view transaction log
        }
    }
}
