namespace LibraryWithArrays
{
    public class Copy
    {
        public Book Book { get; } //instance of book

        public Copy(Book book) // constructor
        {
            Book = book;
            book.AddCopy(this);
        }

    }
}