using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class BookShop
    {
        public List<Book> AvailableSales { get; set; } //Book objects that are available for sale
        public List<Book> SoldSales { get; set; } //Book objects that have been sold
        public string name;
        public BookShop(string aName)
        {
            name = aName;
            AvailableSales = new List<Book>(); // creating object reference list
            SoldSales = new List<Book>();
        }
        
        // methods or functions
        public void addBook(Book b)  //add Book for-sale list
        {
            AvailableSales.Add(b);
            Console.WriteLine("Added item!");
        }

        public void sellBook(Book a) // remove book for-sale and add to sold-list
        {
            AvailableSales.Remove(a);
            SoldSales.Add(a);
            Console.WriteLine("Items on for-sale list: " + AvailableSales.Count);
            Console.WriteLine("Items on sold-sale list: " + SoldSales.Count);
        }
        public void reportSales(Book c) //add price tags of all books in sold lists
        {
            double sum = 0;
            foreach(var item in SoldSales)
            {
                Console.WriteLine("List regarding price tag: " + c.priceTag);
                sum += c.priceTag;
            }
        }


    }
}
