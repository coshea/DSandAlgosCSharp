using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List.Tests
{
    [TestClass()]
    public class IntersectionOfTwoLinkedListsTests
    {
        [TestMethod()]
        public void GetIntersectionNodeTest()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(7);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            l2.next.next.next = l1.next.next;

            var tester = new IntersectionOfTwoLinkedLists();
            var result = tester.GetIntersectionNode(l1, l2);
        }
    }
}