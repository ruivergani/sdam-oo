namespace ObjectConstructor
{

    class Book
    {

        private string author;
        private string borrowerName;
        private string title;

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
