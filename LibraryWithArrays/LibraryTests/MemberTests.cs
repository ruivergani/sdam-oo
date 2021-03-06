using LibraryWithArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        public void Test_WhenMemberIsCreated_ExpectNameIsCorrect()
        {
            Member m = new Member("Graham");

            Assert.AreEqual("Graham", m.Name); //using Assert and comparing if the new object name graham is equal fo graham = meaning the object was created
        }

        [TestMethod]
        public void Test_WhenTwoConsecutiveMembersAreCreated_ExpectTheIdOfTheSecondMemberIsonemoreThantheidofthefirst()
        {
            Member m1 = new Member("");
            Member m2 = new Member("");

            Assert.AreEqual(m1.Id + 1, m2.Id);
        }
    }
}
