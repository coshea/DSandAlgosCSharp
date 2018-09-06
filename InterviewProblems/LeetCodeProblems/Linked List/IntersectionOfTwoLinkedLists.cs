using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List
{
    /// <summary>
    /// Leetcode 160. Intersection of Two Linked Lists
    /// https://leetcode.com/problems/intersection-of-two-linked-lists/description/
    /// Write a program to find the node at which the intersection of two singly linked lists begins.
    /// </summary>
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            if (headA == null || headB == null)
            {
                return null;
            }

            ListNode p1 = headA;
            ListNode p2 = headB;

            int len1 = 0;
            int len2 = 0;

            // Get the length of the two lists.
            while (p1 != null || p2 != null)
            {
                if (p1 != null)
                {
                    len1++;
                    p1 = p1.next;
                }
                if (p2 != null)
                {
                    len2++;
                    p2 = p2.next;
                }
            }

            p1 = headA;
            p2 = headB;

            // Align them to the same start point.
            while (len1 < len2)
            {
                p2 = p2.next;
                len2--;
            }

            while (len2 < len1)
            {
                p1 = p1.next;
                len1--;
            }

            // Move them together until finding the intersection point, or the end null
            while (p1 != null || p2 != null)
            {
                if (p1 == p2)
                {
                    return p1;
                }

                p1 = p1.next;
                p2 = p2.next;
            }

            return null;
        }
    }
}
