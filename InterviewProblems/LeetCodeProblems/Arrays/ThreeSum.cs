using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    /// <summary>
    /// Leetcode 15. 3Sum
    /// https://leetcode.com/problems/3sum/description/
    /// Given an array nums of n integers, are there elements a, b, c 
    /// in nums such that a + b + c = 0? 
    /// Find all unique triplets in the array which gives the sum of zero.
    /// Note:
    /// The solution set must not contain duplicate triplets.
    /// </summary>
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSum_TwoPointer(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> output = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Never let i refer to the same value twice to avoid duplicates.
                if (i != 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int l = i + 1;
                int r = nums.Length - 1;

                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum == 0)
                    {
                        output.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;

                        // Never let l refer to the same value twice (in an output) to avoid duplicates
                        while (l < r && nums[l] == nums[l - 1])
                        {
                            l++;
                        }
                    }
                    else if (sum > 0)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }

            return output;
        }
    }
}
