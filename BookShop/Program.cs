using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Shop");

            Book javaBook = new Book("Java is Ace!", "Graham Mansfield", 30.50);
            Book cSharpBook = new Book("C# is good!", "Jan Lawton", 10);
            Book pythonBook = new Book("What is Python?", null, 20.30);
            Book programmingBook = new Book("", "Kelvin Hilton", 30.99);

        }

    }
}
