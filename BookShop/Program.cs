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
            Book programmingBook = new Book("", "Kelvin Hilton", 30.99);

            BookShop library01 = new BookShop("Wilson Library"); // BookShop Object

            library01.addBook(javaBook);
            library01.addBook(cSharpBook);
            library01.addBook(pythonBook);
            library01.addBook(programmingBook);
            Console.WriteLine("Items on for-sale list: " + library01.AvailableSales.Count);



        }

    }
}
