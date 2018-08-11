using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class ReverseAString
    {
        /// <summary>
        /// Problem #26
        /// Write a method to reverse a string in-place
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Reverse(string str)
        {
            char[] strChars = str.ToCharArray();

            int leftIndex = 0;
            int rightIndex = strChars.Length - 1;

            while (leftIndex < rightIndex)
            {
                // Swap characters
                char temp = strChars[leftIndex];
                strChars[leftIndex] = strChars[rightIndex];
                strChars[rightIndex] = temp;

                // Move towards middle
                leftIndex++;
                rightIndex--;
            }

            return new string(strChars);
        }

        /// <summary>
        /// Implementing with a stack for fun
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string ReverseWithStack(string message)
        {
            StringBuilder newMessage = new StringBuilder();

            var messageArray = message.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (var letter in messageArray)
            {
                stack.Push(letter);
            }

            while (stack.Count > 0)
            {
                newMessage.Append(stack.Pop());
            }

            return newMessage.ToString();
        }
    }
}
