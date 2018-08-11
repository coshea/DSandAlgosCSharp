using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class DuplicateNumber
    {
        /// <summary>
        /// 287. Find the Duplicate Number
        /// Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), 
        /// prove that at least one duplicate number must exist. 
        /// Assume that there is only one duplicate number, find the duplicate one.
        /// Note:
        ///     You must not modify the array(assume the array is read only).
        ///     You must use only constant, O(1) extra space.
        ///     Your runtime complexity should be less than O(n2).
        ///     There is only one duplicate number in the array, but it could be repeated more than once.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindDuplicate_CycleMethod(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            // Find the intersection point of the two runners.
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (fast != slow);


            // Find the "entrance" to the cycle.
            int p1 = nums[0];
            int p2 = slow;

            while (p1 != p2)
            {
                p1 = nums[p1];
                p2 = nums[p2];
            }

            return p1;
        }
    }
}
