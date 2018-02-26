using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.StacksAndQueues
{
    /// <summary>
    /// Problem #20
    /// You want to be able to access the largest element in a stack.
    /// Use the built-in Stack class to implement a new class MaxStack 
    /// with a method GetMax() that returns the largest element in the 
    /// stack.GetMax() should not remove the item.
    /// </summary>
    public class MaxStack
    {
        Stack<int> _stack = new Stack<int>();
        Stack<int> _maxes = new Stack<int>();

        // Add a new item to the top of our stack. If the item is greater
        // than or equal to the last item in _maxes, it's
        // the new max! So we'll add it to _maxes.
        public void Push(int item)
        {
            _stack.Push(item);
            if (_maxes.Count == 0 || item > _maxes.Peek())
            {
                _maxes.Push(item);
            }
        }

        // Remove and return the top item from our stack. If it equals
        // the top item in _maxes, they must have been pushed in together.
        // So we'll pop it out of _maxestoo.
        public int Pop()
        {
            int item = _stack.Pop();

            if(item == _maxes.Peek())
            {
                _maxes.Pop();
            }

            return item;
        }

        // The last item in _maxesis the max item in our stack.
        public int GetMax()
        {
            return _maxes.Peek();
        }
    }
}
