using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.StacksAndQueues
{
    public class MinStackNoExtraStack
    {
        private Stack<long> stack = new Stack<long>();
        long min = int.MaxValue;

        public MinStackNoExtraStack()
        {

        }

        public void Push(int x)
        {
            stack.Push(x - min);
            min = Math.Min(x, min);
        }

        public void Pop()
        {
            long m = stack.Pop();
            min = Math.Max(min - m, min);
        }

        public int Top()
        {
            return (int)Math.Max(stack.Peek() + min, min);
        }

        public int GetMin()
        {
            return (int)min;
        }
    }
}
