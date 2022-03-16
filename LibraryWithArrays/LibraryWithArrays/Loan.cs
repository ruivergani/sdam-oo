﻿ using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWithArrays
{
    public class Loan
    {
        private static int nextId = 1;
        public Member Borrower { get; } //type Member (class)
        public Copy Copy { get;  }
        public DateTime DueDate { get; private set;  } // comes from system namespace - set is only available inside this class
        public int Id { get;  }
        public DateTime LoanDate { get; }  // type: DateTime comes from datetime
        public int NumberOfRenewals { get; private set;  }
        public DateTime ReturnDate { get; private set; }

        public Loan(Member borrower, Copy copy)
        {
            Borrower = borrower;
            Copy = copy;
        }
        public bool RenewLoan()
        {
            if(NumberOfRenewals < 3) // in case is less than 3
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
        public bool ReturnBook()
        {
            if (ReturnDate == null) //book has not yet been returned
            {
                ReturnDate = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
