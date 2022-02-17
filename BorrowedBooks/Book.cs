namespace BorrowedBooks
{

    class Book
    {

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

        public Book(string theTitle, string theAuthor)
        {
            Author = theAuthor;
            BorrowerName = "";
            Title = theTitle;
        }
    }
}
