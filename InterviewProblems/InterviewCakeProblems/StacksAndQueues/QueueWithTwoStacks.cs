using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.StacksAndQueues
{
    /// <summary>
    /// Problem #19
    /// Implement a queue with 2 stacks.Your queue should have an enqueue and 
    /// a dequeue method and it should be "first in first out" (FIFO).
    /// </summary>
    public class QueueWithTwoStacks
    {
        private Stack<object> _inStack = new Stack<object>();
        private Stack<object> _outStack = new Stack<object>();
        
        public void Enqueue(object item)
        {
            _inStack.Push(item);
        }

        public object Dequeue(object item)
        {
            if (_outStack.Count == 0)
            {
                // Move items from inStack to outStack, reversing order
                while (_inStack.Count > 0)
                {
                    object newInStackItem = _inStack.Pop();
                    _outStack.Push(newInStackItem);
                }

                if (_outStack.Count == 0)
                {
                    throw new InvalidOperationException("Can't dequeue from empty queue!");
                }
            }

            return _outStack.Pop();
        }
    }
}
