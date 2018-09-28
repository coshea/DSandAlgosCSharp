using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class ValidPalindrome
    {
        /// <summary>
        /// Leetcode 680. Valid Palindrome II
        /// https://leetcode.com/problems/valid-palindrome-ii/description/
        /// Given a non-empty string s, you may delete at most one character. 
        /// Judge whether you can make it a palindrome.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidPalindromeII(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left <= right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    var l = left + 1;
                    var r = right - 1;
                    return isPalindrome(s, l, right)
                        || isPalindrome(s, left, r);
                }
            }

            return true;
        }

        private bool isPalindrome(string s, int left, int right)
        {
            while (left <= right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
