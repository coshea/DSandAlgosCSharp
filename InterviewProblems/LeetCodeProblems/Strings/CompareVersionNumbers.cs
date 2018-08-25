using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings
{
    /// <summary>
    /// Leetcode 165. Compare Version Numbers
    /// Compare two version numbers version1 and version2.
    /// If version1 > version2 return 1; if version1<version2 return -1; otherwise return 0.
    /// You may assume that the version strings are non-empty and contain only digits and the.character.
    /// The.character does not represent a decimal point and is used to separate number sequences.
    /// For instance, 2.5 is not "two and a half" or "half way to version three", 
    /// it is the fifth second-level revision of the second first-level
    /// </summary>
    public class CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');

            int index = 0;

            while (index < v1.Length || index < v2.Length)
            {
                int num1 = 0;
                int num2 = 0;

                if (v1.Length > index)
                {
                    num1 = Convert.ToInt32(v1[index]);
                }
                if (v2.Length > index)
                {
                    num2 = Convert.ToInt32(v2[index]);
                }

                int result = CompareNums(num1, num2);

                if (result != 0)
                {
                    return result;
                }

                index++;
            }

            return 0;

        }


        private int CompareNums(int num1, int num2)
        {
            if (num1 > num2)
            {
                return 1;
            }
            if (num1 < num2)
            {
                return -1;
            }

            return 0;
        }
    }
}
