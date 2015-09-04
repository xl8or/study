using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingCode;

namespace UnitTestCrackingCode
{
    [TestClass]
    public class UniqueTest
    {
        [TestMethod]
        public void CheckTrueCases()
        {
            var uni=new Unique();
            bool actual= Unique.unique("ABCDEFG");
            Assert.AreEqual(true, actual);
        }
         [TestMethod]
        public void CheckFalseCases()
        {
            var uni = new Unique();
            bool actual = Unique.unique("ABCDEFGA");
            Assert.AreEqual(false, actual);
        }
         [TestMethod]
        public void CheckCaseTrueCases()
        {
            var uni = new Unique();
            bool actual = Unique.unique("ABCDEFGa");
            Assert.AreEqual(true, actual);
        }

    }
}
