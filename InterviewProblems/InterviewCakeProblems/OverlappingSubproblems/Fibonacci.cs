using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.OverlappingSubproblems
{
    /// <summary>
    /// Question #15 - 
    /// Write a method Fib() that a takes an integer nn and returns the nnth Fibonacci number
    /// </summary>
    public class FibonacciRecursive
    {
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    public class FibonacciMemoize
    {
        private Dictionary<int, int> dictionary = new Dictionary<int, int>();

        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int result;
            if (!dictionary.TryGetValue(n, out result))
            {
                result = Fibonacci(n - 1) + Fibonacci(n - 2);
                dictionary.Add(n, result);
            }

            return result;
        }
    }

    public class FibonacciBottomUp
    {
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int n2Value = 0;
            int n1Value = 1;
            int current = 0;

            for (int i = 1; i < n; i++)
            {
                current = n1Value + n2Value;
                n2Value = n1Value;
                n1Value = current;
            }

            return current;
        }
    }
}
