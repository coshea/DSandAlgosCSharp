using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List
{
    [TestClass()]
    public class AddTwoNumbersTests
    {
        [TestMethod()]
        public void GetAddTwoNumbersTest()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var tester = new AddTwoNumbers();
            var result = tester.GetAddTwoNumbers(l1, l2);

            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }

        [TestMethod()]
        public void GetAddTwoNumbersTest_2()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(8);

            ListNode l2 = new ListNode(0);

            var tester = new AddTwoNumbers();
            var result = tester.GetAddTwoNumbers(l1, l2);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(8, result.next.val);
        }
    }
}