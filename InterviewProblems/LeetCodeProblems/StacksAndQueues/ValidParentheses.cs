using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.StacksAndQueues
{
    /// <summary>
    /// Leetcode #20. Valid Parentheses
    /// </summary>
    class ValidParentheses
    {
        Dictionary<char, char> opens = new Dictionary<char, char>()
    {
        {'(', ')'},
        {'{', '}'},
        {'[', ']'}

    };

        Dictionary<char, char> closes = new Dictionary<char, char>()
    {
        {')', '('},
        {'}', '{'},
        {']', '['}
    };

        Stack<char> openStack = new Stack<char>();
        Stack<char> closeStack = new Stack<char>();

        public bool IsValid(string s)
        {
            foreach (char c in s)
            {
                if (opens.ContainsKey(c))
                    openStack.Push(c);
                else if (closes.ContainsKey(c))
                {
                    if (openStack.Count == 0)
                        return false;
                    var left = openStack.Pop();
                    var right = closes[c];
                    if (left != right)
                        return false;
                }
            }

            return openStack.Count == 0;
        }
    }
}
