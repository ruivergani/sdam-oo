using LibraryWithArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTests
{
    [TestClass]
    public class BookTests
    {
        //[TestMethod]
        //public void Test_WhenBookIsCreated_ExpectAuthorIsCorrect()
        //{
        //    Book b = new Book("Graham", "", "");

        //    Assert.AreEqual("Graham", b.Author);
        //}

        //[TestMethod]
        //public void Test_WhenBookIsCreated_ExpectISBNIsCorrect()
        //{
        //    Book b = new Book("", "1234567890123", "");

        //    Assert.AreEqual("1234567890123", b.ISBN);
        //}

        //[TestMethod]
        //public void Test_WhenBookIsCreated_ExpectTitleIsCorrect()
        //{
        //    Book b = new Book("", "", "Arrays are static");

        //    Assert.AreEqual("Arrays are static", b.Title);
        //}

        //[TestMethod]
        //public void Test_WhenBookIsCreated_ExpectItHasNoCopies()
        //{
        //    Book b = new Book("", "", "");

        //    Assert.AreEqual(0, b.GetCopies().Length);
        //}

        //[TestMethod]
        //public void Test_WhenTwoConsecutiveBooksAreCreated_ExpectTheIdOfTheSecondBookIsOneMoreThanTheIdOfTheFirst()
        //{
        //    Book b1 = new Book("", "", "");
        //    Book b2 = new Book("", "", "");

        //    Assert.AreEqual(b1.Id+1, b2.Id);
        //}

        //[TestMethod]
        //public void Test_WhenBookHasNineCopies_ExpectAnotherCopyCanBeAdded()
        //{
        //    Book b = new Book("", "", "");
        //    for (int i = 0; i < 9; i++)
        //    {
        //        new Copy(b);
        //    }
        //    Copy c = new Copy(b);

        //    Assert.AreEqual(c, b.GetCopies()[9]);
        //}

        //[TestMethod]
        //public void Test_WhenBookHasTenCopies_ExpectAnotherCopyCanBeAdded()
        //{
        //    Book b = new Book("", "", "");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        new Copy(b);
        //    }
        //    Copy c = new Copy(b);

        //    Assert.AreEqual(c, b.GetCopies()[10]);
        //}

        //[TestMethod]
        //public void Test_WhenCopiesAreAddedToABook_ExpectCopiesAreHeldInTheOrderTheyAreAdded()
        //{
        //    Book b = new Book("", "", "");
        //    Copy[] copies = 
        //        {
        //            new Copy(b),
        //            new Copy(b),
        //            new Copy(b),
        //            new Copy(b)
        //        };

        //    CollectionAssert.AreEqual(copies, b.GetCopies());
        //}
    }
}
