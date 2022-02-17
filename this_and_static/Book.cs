namespace this_and_static
{

    class Book
    {

        public static int NumberOfBooksCreated { get; private set; } = 0;

        private string author;
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                if (value == null)
                {
                    author = "Anon";
                }
                else
                {
                    author = value;
                }
            }
        }

        public string BorrowerName { get; set; }

        private string title;
        public string Title
        {
            get
            {
                return "'" + title + "'";
            }

            set
            {
                if (value.Length == 0)
                {
                    title = "???";
                }
                else
                {
                    title = value;
                }
            }
        }

        public Book(string Title, string Author)
        {
            this.Author = Author;
            BorrowerName = "";
            this.Title = Title;
            NumberOfBooksCreated += 1;
        }
    }
}
