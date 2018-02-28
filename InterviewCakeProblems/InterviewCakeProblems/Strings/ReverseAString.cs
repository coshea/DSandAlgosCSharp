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
    }
}
