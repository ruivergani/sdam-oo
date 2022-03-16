using System;

namespace LibraryWithArrays
{
    public class Loan
    {
        private static int nextId = 1;
        public Member Borrower { get; } //type Member (class)
        public Copy Copy { get; set; }
        public DateTime DueDate { get; private set;  } // comes from system namespace - set is only available inside this class
        public int Id { get;  }
        public DateTime LoanDate { get; }  // type: DateTime comes from datetime
        public int NumberOfRenewals { get; private set;  }
        public DateTime ReturnDate { get; private set; }

        public Loan(Member borrower, Copy copy)
        {
            Id = nextId++;
            Borrower = borrower;
            Copy = copy;
            copy.State = Copy.ON_LOAN_STATE; // setting the state on the copy
            LoanDate = DateTime.Now;
            DueDate = LoanDate.AddDays(14); // method from system
        }
        // set available only in the class you type private set
        public bool RenewLoan()
        {
            if(NumberOfRenewals < 3) // if in case is less than 3
            {
                DueDate = DueDate.AddDays(14); // add 14 days to the due date
                NumberOfRenewals++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReturnBook() // set return date to now
        {
            if (ReturnDate.ToBinary() == 0) //book has not yet been returned (nulo for return date)
            {
                ReturnDate = DateTime.Now; // default value
                Copy.State = Copy.AVAILABLE_STATE; // set the state to available when returning the book
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
