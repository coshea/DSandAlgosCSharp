using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Linked_Lists
{
    public class LinkListProblems
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
    }
}
