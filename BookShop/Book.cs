using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Book
    {
        public string author { get; set; }
        public string borrowerName { get; set; }
        public string title { get; set; }

        public Book(string theTitle, string theAuthor)
        {
            author = theAuthor;
            borrowerName = "";
            title = theTitle;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetBorrowerName()
        {
            return borrowerName;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetBorrowerName(string theBorrowerName)
        {
            borrowerName = theBorrowerName;
        }
    }
}
