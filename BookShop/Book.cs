using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Book
    {
        public string author { get; set; }
        public string title { get; set; }
        public double priceTag { set; get; }

        public Book(string theTitle, string theAuthor, double aPricetag)
        {
            author = theAuthor;
            title = theTitle;
            priceTag = aPricetag;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetTitle()
        {
            return title;
        }

    }
}
