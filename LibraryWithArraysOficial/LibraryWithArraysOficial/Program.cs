using System;

namespace LibraryWithArrays
{
    class Program
    {
        private const int VIEW_ALL_BOOKS = 1;
        private const int VIEW_ALL_MEMBERS = 2;
        private const int VIEW_ALL_LOANS = 3;
        private const int BORROW_BOOK = 4;
        private const int RENEW_LOAN = 5;
        private const int RETURN_BOOK = 6;
        private const int EXIT = 7;

        private static readonly Library library = new Library();

        static void Main(string[] args)
        {
            DisplayMenu();
            int choice = GetInteger("Option: > ");

            while (choice != EXIT)
            {
                switch (choice)
                {
                    case VIEW_ALL_BOOKS:
                        ViewAllBooks();
                        break;
                    case VIEW_ALL_MEMBERS:
                        ViewAllMembers();
                        break;
                    case VIEW_ALL_LOANS:
                        ViewAllLoans();
                        break;
                    case BORROW_BOOK:
                        BorrowBook();
                        break;
                    case RENEW_LOAN:
                        RenewLoan();
                        break;
                    case RETURN_BOOK:
                        ReturnBook();
                        break;
                    default:
                        Console.WriteLine("\nERROR: Option not recognised. Please try again.");
                        break;
                }
                DisplayMenu();
                choice = GetInteger("Option: > ");
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine(VIEW_ALL_BOOKS + " .View all books");
            Console.WriteLine(VIEW_ALL_MEMBERS + " .View all members");
            Console.WriteLine(VIEW_ALL_LOANS + " .View all loans");
            Console.WriteLine(BORROW_BOOK + " .Borrow book");
            Console.WriteLine(RENEW_LOAN + " .Renew loan");
            Console.WriteLine(RETURN_BOOK + " .Return book");
            Console.WriteLine(EXIT + " .Exit");
            Console.WriteLine("\n");
        }

        private static int GetInteger(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void BorrowBook()
        {
            Console.Write("\nMember id: > ");
            int memberId = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCopy id: > ");
            int copyId = Convert.ToInt32(Console.ReadLine());

            Loan loan = library.BorrowBook(copyId, memberId);

            if (loan != null)
            {
                Console.WriteLine("Success. This book is due back on " + loan.DueDate);
            }
            else
            {
                Console.WriteLine("This book cannot be borrowed");
            }
        }

        private static void RenewLoan()
        {
            Console.Write("\nMember id: > ");
            int memberId = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCopy id: > ");
            int copyId = Convert.ToInt32(Console.ReadLine());

            Loan loan = library.RenewLoan(copyId, memberId);

            if (loan != null)
            {
                Console.WriteLine("Success. This book is now due back on " + loan.DueDate);
            }
            else
            {
                Console.WriteLine("This loan cannot be renewed");
            }
        }

        private static void ReturnBook()
        {
            Console.Write("\nMember id: > ");
            int memberId = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCopy id: > ");
            int copyId = Convert.ToInt32(Console.ReadLine());

            Loan loan = library.ReturnBook(copyId, memberId);

            if (loan != null)
            {
                Console.WriteLine("Success. This book has been returned");
            }
            else
            {
                Console.WriteLine("This book cannot be returned");
            }
        }

        private static void ViewAllBooks()
        {
            Console.WriteLine("\nAll Books\n=========");
            Console.WriteLine("{0, -4} {1, -20}\t{2, -10}\t{3}", "ID", "Title", "Author", "ISBN");
            foreach (Book b in library.GetAllBooks())
            {
                Console.WriteLine(
                    "\n{0, -4} {1, -20}\t{2, -10}\t{3}",
                    b.Id,
                    b.Title,
                    b.Author,
                    b.ISBN);
                Console.WriteLine("{0, 5}Copies\n{0, 5}======", " ");
                Console.WriteLine("{0, 5}{1, -4} {2}", " ", "ID", "State");
                foreach (Copy c in b.GetCopies())
                {
                    Console.WriteLine("{0, 5}{1, -4} {2}", " ", c.Id, c.State);
                }
            }
        }

        private static void ViewAllLoans()
        {
            Console.WriteLine("\nAll Loans\n===========");

            Loan[] loans = library.GetAllLoans();

            if (loans.Length > 0)
            {
                Console.WriteLine(
                    "{0, 24} {1, 22}",
                    "Borrower",
                    "Copy");
                Console.WriteLine(
                    "{0, 4} {1, -10} {2, -4}  {3, -20} {4, -4}  {5, -20} {6, -10} {7, -10} {8}",
                    "ID",
                    "Loan Date",
                    "ID",
                    "Name",
                    "ID",
                    "Name",
                    "Due Date",
                    "Return Date",
                    "Renewals");

                foreach (Loan loan in library.GetAllLoans())
                {
                    Console.WriteLine(
                        "{0, 4} {1, 10} {2, 4}: {3, -20} {4, 4}: {5, -20} {6, 10} {7, 10}  {8}",
                        loan.Id,
                        loan.LoanDate.ToString("dd/MM/yyyy"),
                        loan.Borrower.Id.ToString().PadLeft(4, '.'),
                        loan.Borrower.Name,
                        loan.Copy.Id.ToString().PadLeft(4, '.'),
                        loan.Copy.Book.Title,
                        loan.DueDate.ToString("dd/MM/yyyy"),
                        !loan.ReturnDate.Equals(DateTime.FromBinary(0)) ? loan.ReturnDate.ToString("dd/MM/yyyy") : "---   ",
                        loan.NumberOfRenewals);
                }
            }
            else
            {
                Console.WriteLine("No loans");
            }
        }

        private static void ViewAllMembers()
        {
            Console.WriteLine("\nAll Members\n===========");
            foreach (Member m in library.GetAllMembers())
            {
                Console.WriteLine(m.Id + ": " + m.Name);
            }
        }
    }
}
