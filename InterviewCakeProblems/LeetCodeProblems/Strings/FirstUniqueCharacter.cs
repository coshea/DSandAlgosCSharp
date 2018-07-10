using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings
{
    /// <summary>
    /// Leetcode 387. First Unique Character in a String
    /// Given a string, find the first non-repeating character in it and return it's index. 
    /// If it doesn't exist, return -1.
    /// Examples:
    ///     s = "leetcode"
    ///     return 0.
    ///     s = "loveleetcode",
    ///     return 2.
    /// Note: You may assume the string contain only lowercase letters.
    /// </summary>
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (dict.ContainsKey(c))
                {
                    dict[c] = -1;
                }
                else
                {
                    dict.Add(s[i], i);
                }
            }

            foreach (var item in dict.Keys)
            {
                if (dict[item] != -1)
                {
                    return dict[item];
                }
            }

            return -1;
        }
    }
}
