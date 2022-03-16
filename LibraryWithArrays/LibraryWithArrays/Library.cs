using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWithArrays
{
    public class Library
    {
        public List<Book> Books { get; } // List of Book objects with get
        public Copy[] copies { get; } // Make an array named copies of the type Copy
        private List<Loan> Loans { get; }
        private List<Member> Members { get; }
        public Library() // constructor - initialise list
        {
            Books = new List<Book>();
            copies = new Copy[50]; // you need to set the size 
            Loans = new List<Loan>();
            Members = new List<Member>();
        }
        // creating methods
        private Copy FindCopy(int copyId) //return Copy object
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
        private Member FindMember(int memberId)
        {
            // if the member is not found return null - reason for using try
            return Members[memberId]; // it is a list

        }
    }
}
