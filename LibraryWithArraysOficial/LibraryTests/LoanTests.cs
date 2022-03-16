using LibraryWithArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryTests
{
    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectBorrowerToBeCorrect()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.AreEqual(m, loan.Borrower);
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectCopyToBeCorrect()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.AreEqual(c, loan.Copy);
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectLoanDateToBeNow()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            string expectedLoanDate = DateTime.Now.ToString("dd/MM/yyyy");
            Assert.AreEqual(expectedLoanDate, loan.LoanDate.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectDueDateToBe14DaysAfterLoanDate()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            string expectedDueDate = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            Assert.AreEqual(expectedDueDate, loan.DueDate.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectReturnDateToBeZero()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.AreEqual(0, loan.ReturnDate.ToBinary());
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectNumberOfRenewalsToBeCorrect()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.AreEqual(0, loan.NumberOfRenewals);
        }

        [TestMethod]
        public void Test_WhenLoanIsCreated_ExpectCopyStateToBeOnLoan()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.AreEqual(Copy.ON_LOAN_STATE, loan.Copy.State);
        }

        [TestMethod]
        public void Test_WhenTwoConsecutiveLoansAreCreated_ExpectTheIdOfTheSecondLoanIsOneMoreThanTheIdOfTheFirst()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c1 = new Copy(b);
            Copy c2 = new Copy(b);

            Loan loan1 = new Loan(m, c1);
            Loan loan2 = new Loan(m, c2);

            Assert.AreEqual(loan1.Id + 1, loan2.Id);
        }

        [TestMethod]
        public void Test_WhenRenewableLoanIsRenewed_ExpectNumberOfRenewalsToBeIncremented()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            int numRenewals = loan.NumberOfRenewals;
            loan.RenewLoan();

            Assert.AreEqual(numRenewals + 1, loan.NumberOfRenewals);
        }

        [TestMethod]
        public void Test_WhenLoanIsRenewed_ExpectDueDateToBeHave14DaysAdded()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            string expectedDueDate = loan.DueDate.AddDays(14).ToString("dd/MM/yyyy");

            loan.RenewLoan();

            Assert.AreEqual(expectedDueDate, loan.DueDate.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Test_WhenLoanHasBeenRenewedTwice_ExpectLoanCanBeRenewed()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            loan.RenewLoan();
            loan.RenewLoan();

            Assert.IsTrue(loan.RenewLoan());
        }

        [TestMethod]
        public void Test_WhenLoanHasBeenRenewedThreeTimes_ExpectLoanCannotBeRenewed()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            loan.RenewLoan();
            loan.RenewLoan();
            loan.RenewLoan();

            Assert.IsFalse(loan.RenewLoan());
        }

        [TestMethod]
        public void Test_WhenLoanHasBeenRenewedThreeTimesAndRenewalIsAttempted_ExpectNumberOfRenewalsIsNotIncremented()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            loan.RenewLoan();
            loan.RenewLoan();
            loan.RenewLoan();

            Assert.AreEqual(3, loan.NumberOfRenewals);
        }

        [TestMethod]
        public void Test_WhenLoanHasBeenRenewedThreeTimesAndRenewalIsAttempted_ExpectDueDateIsNotChanged()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            loan.RenewLoan();
            loan.RenewLoan();
            loan.RenewLoan();

            string expectedDueDate = loan.DueDate.ToString("dd/MM/yyyy");

            loan.RenewLoan();

            Assert.AreEqual(expectedDueDate, loan.DueDate.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Test_WhenBorrowedBookIsReturned_ExpectReturnDateToBeNow()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            string expectedReturnDate = DateTime.Now.ToString("dd/MM/yyyy");

            loan.ReturnBook();

            Assert.AreEqual(expectedReturnDate, loan.ReturnDate.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Test_WhenBorrowedBookIsReturned_ExpectCopyStateToBeAvailable()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            loan.ReturnBook();

            Assert.AreEqual(Copy.AVAILABLE_STATE, c.State);
        }

        [TestMethod]
        public void Test_WhenBorrowedBookIsReturned_ExpectTrue()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);

            Assert.IsTrue(loan.ReturnBook());
        }

        [TestMethod]
        public void Test_WhenBookIsReturnedTwice_ExpectFalse()
        {
            Member m = new Member("");
            Book b = new Book("", "", "");
            Copy c = new Copy(b);

            Loan loan = new Loan(m, c);
            loan.ReturnBook();

            Assert.IsFalse(loan.ReturnBook());
        }
    }
}
