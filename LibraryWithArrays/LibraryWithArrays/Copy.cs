namespace LibraryWithArrays
{
    public class Copy
    {
        public Book Book { get; } //instance of book
        public static string AVAILABLE_STATE = "Available";
        public static string ON_LOAN_STATE = "On loan";

        private static int nextId = 1;
        public int Id { get; }
        public string State { get; }
        public Copy(Book book) // constructor
        {
            Book = book;
            Id = nextId++;
            State = AVAILABLE_STATE;
            book.AddCopy(this);
        }


    }
}