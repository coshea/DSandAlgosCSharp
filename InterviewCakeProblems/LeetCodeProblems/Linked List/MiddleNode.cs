using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    /// <summary>
    /// Leetcode #876. Middle of the Linked List
    /// Given a non-empty, singly linked list with head node head, return a middle node of linked list.
    /// If there are two middle nodes, return the second middle node.
    /// The number of nodes in the given list will be between 1 and 100.
    /// </summary>
    public class MiddleNode
    {
        public ListNode FindMiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }


        public ListNode FindMiddleNodeArray(ListNode head)
        {
            var nodeArray = new List<ListNode>();
            var currentNode = head;
            var count = 0;

            while (currentNode.next != null)
            {
                nodeArray.Add(currentNode);
                currentNode = currentNode.next;
                count++;
            }

            var middle = count / 2;
            return nodeArray[middle];

        }
    }
}
