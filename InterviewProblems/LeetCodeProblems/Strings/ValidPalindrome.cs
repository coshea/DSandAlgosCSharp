using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings
{
    /// <summary>
    /// Leetcode #125 - Valid Palindrome
    /// https://leetcode.com/problems/valid-palindrome/
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// Note: For the purpose of this problem, we define empty string as valid palindrome.
    /// </summary>
    public class ValidPalindrome
    {
        HashSet<string> ValidChars = new HashSet<string>()
    {
        "a",
        "b",
        "c",
        "d",
        "e",
        "f",
        "g",
        "h",
        "i",
        "j",
        "k",
        "l",
        "m",
        "n",
        "o",
        "p",
        "q",
        "r",
        "s",
        "t",
        "u",
        "v",
        "w",
        "x",
        "y",
        "z",
         "0",
         "1",
         "2",
         "3",
         "4",
         "5",
         "6",
         "7",
         "8",
         "9"
    };

        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!ValidChars.Contains(s[start].ToString().ToLower()))
                {
                    start++;
                    continue;
                }
                if (!ValidChars.Contains(s[end].ToString().ToLower()))
                {
                    end--;
                    continue;
                }

                if (!s[start].ToString().Equals(s[end].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}

