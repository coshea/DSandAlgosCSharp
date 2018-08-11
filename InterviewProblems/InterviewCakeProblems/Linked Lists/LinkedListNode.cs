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
}
