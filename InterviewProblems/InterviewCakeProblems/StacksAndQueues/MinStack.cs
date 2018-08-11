using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.StacksAndQueues
{
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();
        private Stack<int> topStack = new Stack<int>();

        public MinStack()
        {

        }

        public void Push(int x)
        {
            stack.Push(x);

            if (topStack.Count == 0)
            {
                topStack.Push(x);
            }
            else
            {
                int top = topStack.Peek();
                if (x > top)
                {
                    topStack.Push(x);
                }
                else
                {
                    topStack.Push(top);
                }
            }


            if (minStack.Count == 0)
            {
                minStack.Push(x);
            }
            else
            {
                int min = minStack.Peek();


                if (x < min)
                {
                    minStack.Push(x);
                }
                else
                {
                    minStack.Push(min);
                }
            }

        }

        public void Pop()
        {
            stack.Pop();
            topStack.Pop();
            minStack.Pop();
        }

        public int Top()
        {
            return topStack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}
