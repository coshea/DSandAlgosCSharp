using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.StacksAndQueues
{
    [TestClass()]
    public class MinStackTests
    {
        [TestMethod()]
        public void MinStackTest_LeetCodeExample1()
        {
            MinStack minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            Assert.AreEqual(-3, minStack.GetMin());
            minStack.Pop();

            Assert.AreEqual(0, minStack.Top());
            Assert.AreEqual(-2, minStack.GetMin());
        }

        [TestMethod()]
        public void MinStackTest_LeetCodeExample2()
        {
            MinStack minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-1);

            Assert.AreEqual(-2, minStack.GetMin());
            Assert.AreEqual(0, minStack.Top());

            minStack.Pop();

            Assert.AreEqual(-2, minStack.GetMin());
        }
    }
}