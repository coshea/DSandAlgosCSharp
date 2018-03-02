using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class MatchingParentheses
    {
        /// <summary>
        /// Problem #28
        /// Write a method that, given a sentence like the one above, 
        /// along with the position of an opening parenthesis, 
        /// finds the corresponding closing parenthesis.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="openingParenIndex"></param>
        /// <returns></returns>
        public int GetClosingParentheses(string sentence, int openingParenIndex)
        {
            int openNestedParens = 0;

            for (int position = openingParenIndex + 1; position < sentence.Length; position++)
            {
                char c = sentence[position];

                if (c == '(')
                {
                    openNestedParens++;
                }
                else if (c == ')')
                {
                    if (openNestedParens == 0)
                    {
                        return position;
                    }
                    else
                    {
                        openNestedParens--;
                    }
                }
            }

            throw new ArgumentException("No closing parenthesis :(", nameof(sentence));
        }

        /// <summary>
        /// Problem #29
        /// Write an efficient method that tells us whether or
        /// not an input string's openers and closers are properly nested.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsBalancedCode(string code)
        {
            var openersToClosers = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };
            
            HashSet<char> closers = new HashSet<char>(openersToClosers.Values);

            var openersStack = new Stack<char>();

            foreach (var c in code)
            {
                if (openersToClosers.ContainsKey(c))
                {
                    openersStack.Push(c);
                }
                else if (closers.Contains(c))
                {
                    if (openersStack.Count == 0)
                    {
                        return false;
                    }

                    var lastOpenner = openersStack.Pop();

                    // If this closer doesn't correspond to the most recently
                    // seen unclosed opener, short-circuit, returning false
                    if (openersToClosers[lastOpenner] != c)
                    {
                        return false;
                    }

                }
            }

            return openersStack.Count == 0;
        }
    }
}
