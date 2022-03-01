using System;
using System.Collections.Generic;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Shop! ");

            Book javaBook = new Book("Java is Ace!", "Graham Mansfield", 30.50);
            Book cSharpBook = new Book("C# is good!", "Jan Lawton", 10);
            Book pythonBook = new Book("What is Python?", null, 20.30);
            Book programmingBook = new Book("Hacker Book", "Kelvin Hilton", 30.99);

            BookShop library01 = new BookShop("Wilson Library"); // BookShop Object

            library01.addBook(javaBook);
            library01.addBook(cSharpBook);
            library01.addBook(pythonBook);
            library01.addBook(programmingBook);
            Console.WriteLine("Items on for-sale list: " + library01.AvailableSales.Count);
            PrintBookAvailableSales(library01); // Print books on the list

            library01.sellBook(pythonBook); // selling book method 
            library01.sellBook(programmingBook); // selling book method 

            Console.WriteLine("Items on for-sale list: " + library01.AvailableSales.Count);
            PrintBookAvailableSales(library01); // Print books on the list

            library01.reportSales(library01);
        }
        public static void PrintBookAvailableSales(BookShop i)
        {
            foreach(var item in i.AvailableSales)
            {
                Console.WriteLine("Book: " + item.title);
            }
        }

        

   }

    
}
