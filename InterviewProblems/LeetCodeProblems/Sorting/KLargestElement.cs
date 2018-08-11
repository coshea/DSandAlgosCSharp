using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Sorting
{
    /// <summary>
    /// 215. Kth Largest Element in an Array
    /// Find the kth largest element in an unsorted array. 
    /// Note that it is the kth largest element in the sorted order, not the kth distinct element.
    /// </summary>
    public class KLargestElement
    {
        public int FindKthLargestLinq(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}
