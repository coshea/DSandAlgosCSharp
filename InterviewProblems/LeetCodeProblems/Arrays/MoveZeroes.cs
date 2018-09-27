using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    /// <summary>
    /// Leetcode 283. Move Zeroes
    /// https://leetcode.com/problems/move-zeroes/description/
    /// Given an array nums, write a function to move all 0's to the 
    /// end of it while maintaining the relative order of the non-zero elements.
    /// Note:
    /// You must do this in-place without making a copy of the array.
    /// Minimize the total number of operations.
    /// </summary>
    public class MoveZeroes
    {
        public void MoveZeroesImpl(int[] nums)
        {
            int lastNonZeroIndex = 0;

            for (int cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    var tmp = nums[cur];
                    nums[cur] = nums[lastNonZeroIndex];
                    nums[lastNonZeroIndex] = tmp;
                    lastNonZeroIndex++;
                }
            }

        }
    }
}
