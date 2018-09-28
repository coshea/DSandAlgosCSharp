using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> sums = new Dictionary<int, int>();

            for (int x = 0; x < nums.Length; x++)
            {
                var diff = target - nums[x];
                if (sums.ContainsKey(diff))
                {
                    return new int[] { sums[diff], x };
                }

                if (!sums.ContainsKey(nums[x]))
                    sums.Add(nums[x], x);
            }

            return null;
        }

        public int[] GetTwoSum_Pointers(int[] nums, int target)
        {
            Array.Sort(nums);

            int l = 0;
            int r = nums.Length - 1;

            while (l < r)
            {
                int sum = nums[l] + nums[r];
                if (sum == target)
                {
                    return new int[] { l, r };
                }

                if (sum > target)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return null;
        }
    }
}
