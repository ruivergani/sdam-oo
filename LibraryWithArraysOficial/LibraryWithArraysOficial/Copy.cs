namespace LibraryWithArrays
{
    public class Copy
    {
        public static readonly string AVAILABLE_STATE = "Available";
        public static readonly string ON_LOAN_STATE = "On loan";

        private static int nextId = 1;

        public int Id { get; }
        public Book Book { get; private set; }

        private string state;
        public string State
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

        public Copy(Book book)
        {
            Id = nextId++;
            Book = book;
            Book.AddCopy(this);
            State = AVAILABLE_STATE;
        }
    }
}
