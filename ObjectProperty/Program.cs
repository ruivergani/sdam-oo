using System;
using System.Collections.Generic;

namespace ObjectProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Book javaBook = new Book("Java is Ace!", "Graham Mansfield");
            Book cSharpBook = new Book("C# is good!", "Jan Lawton");
            Book pythonBook = new Book("What is Python?", "Phil Windridge");
            Book programmingBook = new Book("Learn Programming", "Kelvin Hilton");

            List<Book> books = 
                new List<Book>() { javaBook, cSharpBook, pythonBook, programmingBook };

            PrintBooks(books);

            pythonBook.BorrowerName = "Chris Mountford";
            //pythonBook.SetBorrowerName("Chris Mountford");

            PrintBooks(books);
        }

        static void PrintBooks(List<Book> bookList)
        {
            Console.WriteLine("\nBooks");
            Console.WriteLine("=====");

            bookList.ForEach(PrintBookDetails);
        }

        static void PrintBookDetails(Book b)
        {
            Console.WriteLine(
                "{0, -20} by {1, -18} is {2}", 
                "'" + b.Title + "'", 
                b.Author,
                b.BorrowerName.Length == 0 ? "Available" : "On loan to " + b.BorrowerName);

            // The code below has been changed to use the Book object properties

            //Console.WriteLine(
            //    "{0, -20} by {1, -18} is {2}", 
            //    "'" + b.GetTitle() + "'", 
            //    b.GetAuthor(),
            //    b.GetBorrowerName().Length == 0 ? "Available" : "On loan to " + b.GetBorrowerName());
        }
    }
}
