using System;
using InterviewCakeProblems.Linked_Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Linked_Lists
{
    [TestClass]
    public class LinkedListProblemsTests
    {
        [TestMethod]
        public void FindKToLastNode_ExampleProblem()
        {
            var a = new LinkedListNode(1);
            var b = new LinkedListNode(2);
            var c = new LinkedListNode(3);
            var d = new LinkedListNode(4);
            var e = new LinkedListNode(5);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;

            // Returns the node with value 4 (the 2nd to last node)
            var result = new LinkedListProblems().FindKthToLastNode(2, a);

            Assert.AreEqual(4, result.Value);
        }
    }
}
