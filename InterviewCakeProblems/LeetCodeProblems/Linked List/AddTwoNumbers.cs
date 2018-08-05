using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List
{
    /// <summary>
    /// 2. Add Two Numbers
    /// You are given two non-empty linked lists representing two non-negative integers. 
    /// The digits are stored in reverse order and each of their nodes contain a single digit. 
    /// Add the two numbers and return it as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// </summary>
    public class AddTwoNumbers
    {
        public ListNode GetAddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode(0);
            int carry = 0;

            var node = root;
            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = 0;

                if (sum >= 10)
                {
                    carry = 1;
                    sum -= 10;
                }

                node.val = sum;


                if (l1 != null || l2 != null)
                {
                    node.next = new ListNode(0);
                    node = node.next;
                }
                else if (carry == 1)
                {
                    node.next = new ListNode(1);
                }
            }

            return root;
        }
    }
}
