using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class Palindrome
    {
        /// <summary>
        /// Problem #30
        /// Write an efficient method that checks whether any permutation
        /// of an input string is a palindrome.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool HasPalindromePermutation(string input)
        {
            // Track characters we've seen an odd number of times
            HashSet<char> unpairedCharacters = new HashSet<char>();

            foreach (var c in input)
            {
                if (unpairedCharacters.Contains(c))
                {
                    unpairedCharacters.Remove(c);
                }
                else
                {
                    unpairedCharacters.Add(c);
                }
            }

            // The string has a palindrome permutation if it
            // has one or zero characters without a pair
            return unpairedCharacters.Count <= 1;
        }
    }
}
