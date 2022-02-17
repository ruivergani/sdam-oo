namespace ObjectProperty
{

    class Book
    {

        public string Author { get; }
        public string BorrowerName { get; set; }
        public string Title { get; }

        public Book(string theTitle, string theAuthor)
        {
            Author = theAuthor;
            BorrowerName = "";
            Title = theTitle;
        }

        // The code below is replaced by the use of properties

        //public string GetAuthor()
        //{
        //    return author;
        //}

        //public string GetBorrowerName()
        //{
        //    return borrowerName;
        //}

        //public string GetTitle()
        //{
        //    return title;
        //}

        //public void SetBorrowerName(string theBorrowerName)
        //{
        //    borrowerName = theBorrowerName;
        //}
    }
}
