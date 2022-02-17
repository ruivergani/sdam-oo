using System;
using System.Collections.Generic;

namespace BorrowedBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book javaBook = new Book("Java is Ace!", "Graham Mansfield");
            Book cSharpBook = new Book("C# is good!", "Jan Lawton");
            Book pythonBook = new Book("What is Python?", null);
            Book programmingBook = new Book("", "Kelvin Hilton");

            Address addr1 = new Address(23, "High Street", "Toon Town", "TT4 2RF");

            Person p1 = new Person("Pinocchio", addr1);

            List<Book> books =
                new List<Book>() { javaBook, cSharpBook, pythonBook, programmingBook };

            PrintBooks(books);
            PrintPersonDetails(p1);

            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();

            p1.BorrowBook(cSharpBook);
            p1.BorrowBook(pythonBook);

            PrintBooks(books);
            PrintPersonDetails(p1);

            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();

            p1.ReturnBook(cSharpBook);

            PrintBooks(books);
            PrintPersonDetails(p1);
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
                b.Title,
                b.Author,
                b.BorrowerName.Length == 0 ? "Available" : "On loan to " + b.BorrowerName);
        }

        private static void PrintPersonDetails(Person p)
        {
            Console.WriteLine(
                "\n{0}\n{1}", 
                p.Name, 
                p.HomeAddress.GetFullAddress());

            List<Book> borrowedBooks = p.BorrowedBooks;

            if (borrowedBooks.Count == 0)
            {
                Console.WriteLine("\nNo borrowed books");
            }
            else
            {
                Console.WriteLine("\nBorrowed books");
                Console.WriteLine("==============");

                p.BorrowedBooks.ForEach(PrintBookDetails);
            }
        }
    }
}
