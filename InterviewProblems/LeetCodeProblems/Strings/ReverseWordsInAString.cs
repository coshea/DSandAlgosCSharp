using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings
{
    public class ReverseWordsInAString
    {
        /// <summary>
        /// Leetcode #186 - Reverse Words in a String II
        /// Given an input string , reverse the string word by word. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char[] ReverseWords(char[] str)
        {
            // 1 Reverse whole string
            Reverse(str, 0, str.Length - 1);

            int start = 0;
            // 2 Reverse each word
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    Reverse(str, start, i - 1);
                    start = i + 1;
                }
            }

            // 3 Reverse last word
            Reverse(str, start, str.Length - 1);

            return str;

        }

        private void Reverse(char[] str, int start, int end)
        {
            while (start < end)
            {
                var tmp = str[end];
                str[end] = str[start];
                str[start] = tmp;

                start++;
                end--;
            }
        }

    }
}
