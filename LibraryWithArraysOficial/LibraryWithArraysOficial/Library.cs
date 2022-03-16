using System;

namespace LibraryWithArrays
{
    public class Library
    {
        private Book[] books;
        private Copy[] copies;
        private Loan[] loans;
        private Member[] members;

        private int numBooks;
        private int numCopies;
        private int numLoans;
        private int numMembers;

        public Library()
        {
            books = new Book[10];
            books[0] = new Book("Author 1", "1234567890", "Title 1");
            books[1] = new Book("Author 2", "9123456780", "Title 2");
            books[2] = new Book("Author 3", "8912345670", "Title 3");
            numBooks = 3;

            copies = new Copy[100];
            copies[0] = new Copy(books[0]);
            copies[1] = new Copy(books[1]);
            copies[2] = new Copy(books[0]);
            copies[3] = new Copy(books[2]);
            copies[4] = new Copy(books[2]);
            copies[5] = new Copy(books[2]);
            numCopies = 6;

            members = new Member[10];
            members[0] = new Member("Member 1");
            members[1] = new Member("Member 2");
            members[2] = new Member("Member 3");
            numMembers = 3;

            loans = new Loan[20];
            numLoans = 0;
        }

        public Loan BorrowBook(int copyId, int memberId)
        {
            Loan loan = null;
            Copy copy = FindCopy(copyId);
            Member member = FindMember(memberId);

            if (copy != null && member != null)
            {
                if (copy.State.Equals(Copy.AVAILABLE_STATE))
                {
                    loan = new Loan(member, copy);
                    loans[numLoans++] = loan;
                }
            }
            return loan;
        }

        private Copy FindCopy(int copyId)
        {
            Copy copy = null;
            for (int i = 0; i < numCopies && copy == null; i++)
            {
                if (copies[i].Id == copyId)
                {
                    copy = copies[i];
                }
            }
            return copy;
        }

        private Loan FindLoan(int copyId, int memberId)
        {
            Loan loan = null;
            for (int i = 0; i < numLoans && loan == null; i++)
            {
                if (loans[i].Borrower.Id == memberId 
                    && loans[i].Copy.Id == copyId)
                {
                    loan = loans[i];
                }
            }
            return loan;
        }

        private Member FindMember(int memberId)
        {
            Member member = null;
            for (int i = 0; i < numMembers && member == null; i++)
            {
                if (members[i].Id == memberId)
                {
                    member = members[i];
                }
            }
            return member;
        }

        public Book[] GetAllBooks()
        {
            Book[] existingBooks = new Book[numBooks];
            Array.Copy(books, existingBooks, numBooks);
            return existingBooks;
        }

        public Loan[] GetAllLoans()
        {
            Loan[] existingLoans = new Loan[numLoans];
            Array.Copy(loans, existingLoans, numLoans);
            return existingLoans;
        }

        public Member[] GetAllMembers()
        {
            Member[] existingMembers = new Member[numMembers];
            Array.Copy(members, existingMembers, numMembers);
            return existingMembers;
        }

        public Loan RenewLoan(int copyId, int memberId)
        {
            Loan loan = FindLoan(copyId, memberId);
            if (loan != null)
            {
                if (!loan.RenewLoan())
                {
                    loan = null;
                }
            }
            return loan;
        }

        public Loan ReturnBook(int copyId, int memberId)
        {
            Loan loan = FindLoan(copyId, memberId);
            if (loan != null)
            {
                if (!loan.ReturnBook())
                {
                    loan = null;
                }
            }
            return loan;
        }
    }
}
