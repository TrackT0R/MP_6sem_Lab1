using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace UnitTestForMyStack
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CountMustBeZeroAfterCreation()
        {
            var st = new MyStack<int>();

            Assert.AreEqual(st.Count, 0);
        }
    }
}
