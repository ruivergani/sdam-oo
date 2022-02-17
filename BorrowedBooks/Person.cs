using System.Collections.Generic;

namespace BorrowedBooks
{
    class Person
    {
        public string Name { get; }
        public Address HomeAddress { get; }

        public List<Book> BorrowedBooks { get; }

        public Person(string name, Address homeAddress)
        {
            Name = name;
            HomeAddress = homeAddress;
            BorrowedBooks = new List<Book>();
        }

        public bool BorrowBook(Book b)
        {
            if (!BorrowedBooks.Contains(b))
            {
                BorrowedBooks.Add(b);
                b.BorrowerName = Name;
                return true;
            }
            return false;
        }

        public bool ReturnBook(Book b)
        {
            if (BorrowedBooks.Contains(b))
            {
                BorrowedBooks.Remove(b);
                b.BorrowerName = "";
                return true;
            }
            return false;
        }
    }
}
