using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Linked_Lists
{
    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }
    }


    /// <summary>
    /// Problem #22
    /// Delete a node from a singly-linked list, given only a variable pointing to that node.
    /// </summary>
    class DeleteLinkListNode
    {
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
    }
}
