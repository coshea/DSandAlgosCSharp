using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class MaxSubArray
    {
        /// <summary>
        /// Leetcode 325. Maximum Size Subarray Sum Equals k
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaxSubArrayLen(int[] nums, int k)
        {
            int maxLength = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int sum = 0;
            // Store the sums along the way.
            // Check if current sum - k is present. 
            // Meaning i was location that caused sum == k,
            // so find starting point from index stored at sum - k
            for (int i = 0; i < nums.Length; i++)
            {
                // accumulate sum
                sum += nums[i];

                // when subarray starts from index '0'
                if (sum == k)
                {
                    maxLength = i + 1;
                }

                // make an entry for 'sum' if it is not present in dict
                if (!dict.ContainsKey(sum))
                {
                    dict.Add(sum, i);
                }

                // update max if 'sum-k' is present in dict. 
                if (dict.ContainsKey(sum - k))
                {
                    maxLength = Math.Max(maxLength, i - dict[sum - k]);
                }
            }

            return maxLength;
        }
    }
}
