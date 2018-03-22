using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class SlidingWindowProblems
    {
        /// <summary>
        /// Leetcode #3. Longest Substring Without Repeating Characters
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            var seen = new Dictionary<char, int>();

            int begin = 0;
            int end = 0;
            int len = 0;

            string ans = "";

            while (end < s.Length)
            {
                char current = s[end];

                if (seen.ContainsKey(current) && seen[current] >= begin)
                {
                    begin = seen[current] + 1;
                }
                else
                {
                    seen[current] = end;
                    end++;
                }

                if (end - begin > len)
                {
                    len = end - begin;
                    ans = s.Substring(begin, end - begin);
                }
            }

            return len;

        }

    }
}
