using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWithArrays
{
    public class Library
    {
        public Book[] Books { get; } // List of Book objects with get
        public Copy[] copies { get; } // Make an array named copies of the type Copy
        private Loan[] Loans { get; }
        private Member[] Members { get; }
        public Library() // constructor - initialise list
        {
            Books = new Book[100];
            copies = new Copy[50]; // you need to set the size 
            Loans = new Loan[250];
            Members = new Member[100];
        }
        // creating methods
        private Copy FindCopy(int copyId) // Find Copy - return Copy object
        {
            Copy c = null;
            for (int i = 0; c == null && i < copies.Length; i++) // linear search through the array
            {
                if (copies[i].Id == copyId)
                {
                    c = copies[i]; 
                }
            }
            return c;
        }
        private Member FindMember(int memberId) // Find Member 
        {
            Member m = null;
            for (int i = 0; m == null && i < Members.Length; i++) // linear search through the array
            {
                if (Members[i].Id == memberId)
                {
                    m = Members[i];
                }
            }
            return m;
        }
        private Loan FindLoan(int memberId, int copyId) // Find
        {
            Loan loan = null;
            for (int i = 0; loan == null && i < Loans.Length; i++) // linear search through the array
            {
                if (Loans[i].Borrower.Id == memberId && 
                    Loans[i].Copy.Id == copyId &&
                    Loans[i].ReturnDate.ToBinary() == 0)
                {
                    loan = Loans[i];
                }
            }
            return loan;
        }
    }
}
