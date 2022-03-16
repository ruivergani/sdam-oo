namespace LibraryWithArrays
{
    public class Copy
    {
        public static readonly string AVAILABLE_STATE = "Available"; //attributes
        public static readonly string ON_LOAN_STATE = "On loan";

        private static int nextId = 1; // id

        public int Id { get; }
        public Book Book { get; private set; } // from Book class

        private string state;
        public string State // state of the book (in case there is copy - return if is available or on loan)
        {
            get
            {
                return state;
            }

            set
            {
                if (value.Equals(AVAILABLE_STATE) || value.Equals(ON_LOAN_STATE))
                {
                    state = value;
                }
            }
        }

        public Copy(Book book) // constructor of the class
        {
            Id = nextId++;
            Book = book;
            Book.AddCopy(this);
            State = AVAILABLE_STATE;
        }


    }
}