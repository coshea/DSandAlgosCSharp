using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class SubArraySum
    {
        /// <summary>
        /// Leetcode 
        /// Solution doesn't work
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySum(int[] nums, int k)
        {
            int result = 0;
            int leftIndex = 0;
            int rightIndex = 0;
            int currentSum = nums[0];

            //for (int i = 1; i <= nums.Length; i++)
            while (leftIndex < nums.Length && rightIndex <= nums.Length)
            {
                if (currentSum == k)
                {
                    result++;
                    currentSum -= nums[leftIndex];
                    leftIndex++;
                    continue;
                }
                else if (currentSum > k && leftIndex < rightIndex - 1)
                {
                    currentSum -= nums[leftIndex];
                    leftIndex++;
                }
                else if (rightIndex < nums.Length)
                {
                    currentSum += nums[rightIndex];
                    rightIndex++;
                }

                //walk left index until sum is <= k
                //while (currentSum > k && leftIndex < rightIndex - 1)
                //{
                //    currentSum -= nums[leftIndex];
                //    leftIndex++;
                //}


                //if (rightIndex < nums.Length)
                //{
                //    currentSum += nums[rightIndex];
                //    rightIndex++;
                //}

            }

            return result;
        }
    }
}
