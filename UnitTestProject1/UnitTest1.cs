using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingCode;

namespace UnitTestCrackingCode
{
    [TestClass]
    public class UnitChapter1
    {
        [TestMethod]
        public void CheckTrueCases()
        {
            //var uni=new Unique();
            bool actual= Chapter1.unique("ABCDEFG");
            Assert.AreEqual(true, actual);
        }
         [TestMethod]
        public void CheckFalseCases()
        {
            //var uni = new Unique();
            bool actual = Chapter1.unique("ABCDEFGA");
            Assert.AreEqual(false, actual);
        }
         [TestMethod]
        public void CheckCaseTrueCases()
        {
            //var uni = new Unique();
            bool actual = Chapter1.unique("ABCDEFGa");
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CheckEscapeSpaces()
        {
            string actual = Chapter1.Escape_spaces("This is Sample");
            Assert.AreEqual("This%20is%20Sample", actual);
        }
    }
}
