using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Linked_Lists
{
    public class LinkedListProblems
    {
        /// <summary>
        /// Problem #22
        /// Delete a node from a singly-linked list, given only a variable pointing to that node.
        /// </summary>
        public void DeleteNode(LinkedListNode nodeToDelete)
        {
            // Get the input node's next node, the one we want to skip to
            var nextNode = nodeToDelete.Next;

            if (nextNode != null)
            {
                // Replace the input node's value and pointer with the next
                // node's value and pointer. the previous node now effectively
                // skips over the input node
                nodeToDelete.Value = nextNode.Value;
                nodeToDelete.Next = nextNode.Next;
            }
            else
            {
                // Eep, we're trying to delete the last node!
                throw new InvalidOperationException("Can't delete the last node with this technique!");
            }
        }

        /// <summary>
        /// Problem #23
        /// Write a method ContainsCycle() that takes the first node in a singly-linked list 
        /// and returns a boolean indicating whether the list contains a cycle.
        /// </summary>
        /// <param name="firstNode"></param>
        /// <returns></returns>
        public bool ContainsCycle(LinkedListNode firstNode)
        {
            // Start both runners at the beginning
            var slowCycler = firstNode;
            var fastCycler = firstNode;

            // Until we hit the end of the list
            while (slowCycler.Next != null && fastCycler.Next != null)
            {
                slowCycler = slowCycler.Next;
                fastCycler = fastCycler.Next.Next;

                // Case: fastRunner is about to "lap" slowRunner
                if (slowCycler == fastCycler)
                {
                    return true;
                }
            }

            // Case: fastRunner hit the end of the list
            return false;
        }

        /// <summary>
        /// Problem #24
        /// Write a method for reversing a linked list. Do it in-place.
        /// Your method will have one input: the head of the list.
        /// Your method should return the new head of the list.
        /// </summary>
        /// <param name="headOfList"></param>
        /// <returns></returns>
        public LinkedListNode ReverseLinkedList(LinkedListNode headOfList)
        {
            LinkedListNode previousNode = null;
            LinkedListNode currentNode = headOfList;
            LinkedListNode nextNode = null;

            // Until we have 'fallen off' the end of the list
            while (currentNode != null)
            {
                // Copy a pointer to the next element
                // before we overwrite currentNode.Next
                nextNode = currentNode.Next;

                 // Reverse the 'Next' pointer
                currentNode.Next = previousNode;

                // Step forward in the list
                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
        }

        /// <summary>
        /// Problem #25
        /// Write a method KthToLastNode() that takes an integer kk and the 
        /// headNode of a singly-linked list, and returns the kkth to last node in the list.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="headOfList"></param>
        /// <returns></returns>
        public LinkedListNode FindKthToLastNode(int k, LinkedListNode headOfList)
        {

            var leftNode = headOfList;
            var rightNode = headOfList;

            // Move rightNode to the kth node
            for (int i = 0; i < k - 1; i++)
            {
                // But along the way, if a rightNode doesn't have a next,
                // then k is greater than the length of the list and there
                // can't be a kth-to-last node! we'll raise an error
                if (rightNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(k),
                        $"k is larger than the length of the linked list: {k}");
                }

                rightNode = rightNode.Next;
            }

            // Starting with leftNode on the head,
            // move leftNode and rightNode down the list,
            // maintaining a distance of k between them,
            // until rightNode hits the end of the list
            while (rightNode.Next != null)
            {
                rightNode = rightNode.Next;
                leftNode = leftNode.Next;
            }

            // Since leftNode is k nodes behind rightNode,
            // leftNode is now the kth to last node!
            return leftNode;

        }


    }
}
