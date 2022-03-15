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

            Assert.AreEqual(0, st.Count);
        }

        [TestMethod]
        public void CountMustStayWithPeek()
        {
            var st = new MyStack<int>();
            var cnt = 10;

            for (int i = 0; i < cnt; i++) {
                st.Push(i);
            }

            st.Peek();
            Assert.AreEqual(cnt, st.Count);
        }


        [TestMethod]
        public void CountMustIncreaseWithPush()
        {
            var st = new MyStack<int>();
            var cnt = 10;

            for (int i = 0; i < cnt; i++) {
                st.Push(i);
                Assert.AreEqual(i + 1, st.Count);
            }
        }

        [TestMethod]
        public void CountMustDecreaseWithPop()
        {
            var st = new MyStack<int>();
            var cnt = 10;
            
            for (int i = 0; i < cnt; i++) {
                st.Push(i);
            }
            for (int i = cnt-1; i >= 0; i--) {
                st.Pop();
                Assert.AreEqual(i, st.Count);
            }
        }
        
        [TestMethod]
        public void ElemMustBeInStackAfterAdding()
        {
            var st = new MyStack<int>();
            var cnt = 10;

            for (int i = 0; i < cnt; i++) {
                st.Push(i);
                var p = st.Peek();
                Assert.AreEqual(i, st.Peek());
            }
        }

        [TestMethod]
        public void AllElemsMustBeOnTheirPlaces()
        {
            var st = new MyStack<int>();
            var cnt = 10;

            for (int i = 0; i < cnt; i++) {
                st.Push(i);
            }

            for (int i = cnt - 1; i >= 0; i--) {
                Assert.AreEqual(i, st.Pop());
            }
        }
    }
}
