using System;

namespace LibraryWithArrays
{
    public class Book
    {
        private static int nextId = 1;

        public string Author { get; }
        public int Id { get; }
        public string ISBN { get; }
        public string Title { get; }

        private Copy[] copies;
        private int numCopies;

        public Book(string author, string isbn, string title)
        {
            Id = nextId++;
            Author = author;
            ISBN = isbn;
            Title = title;
            copies = new Copy[10];
            numCopies = 0;
        }

        public void AddCopy(Copy c)
        {
            if (numCopies == copies.Length)
            {
                Copy[] newCopies = new Copy[copies.Length+10];
                Array.Copy(copies, newCopies, copies.Length);
                copies = newCopies;
            }
            copies[numCopies++] = c;
        }

        public Copy[] GetCopies()
        {
            Copy[] existingCopies = new Copy[numCopies];
            Array.Copy(copies, existingCopies, numCopies);
            return existingCopies;
        }
    }
}
