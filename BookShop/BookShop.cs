using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class BookShop
    {
        public List<Book> AvailableSales { get; set; } //Book objects that are available for sale
        public List<Book> SoldSales { get; set; } //Book objects that have been sold

        public BookShop()
        {
            AvailableSales = new List<Book>(); // creating object reference list
            SoldSales = new List<Book>();
        }
        
        // methods or functions
        public void addBook(Book b)  //add Book for-sale list
        {
            AvailableSales.Add(b);
            Console.WriteLine("Items on for-sale list: " + AvailableSales.Count);
        }

        public void sellBook() // remove book for-sale and add to sold-list
        {

        }
        public void reportSales() //add price tags of all books in sold lists
        {

        }


    }
}
