using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class BackTrackingProblems
    {
        /// <summary>
        /// Leetcode #78 - Subsets
        /// Tags: Backtracking, arrays, recursive
        /// Given a set of distinct integers, nums, return all possible subsets (the power set).
        /// Note: The solution set must not contain duplicate subsets.
        /// https://leetcode.com/problems/subsets/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> GetSubsets(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            //Array.Sort(nums);
            BacktrackSubsets(list, new List<int>(), nums, 0);
            return list;
        }

        private void BacktrackSubsets(IList<IList<int>> resultList, List<int> tempList, int[] nums, int start)
        {
            if (start == nums.Length)
            {
                resultList.Add(new List<int>(tempList));
                return;
            }

            //Choosing our number
            tempList.Add(nums[start]);
            BacktrackSubsets(resultList, tempList, nums, start + 1);
            tempList.RemoveAt(tempList.Count - 1);

            //Not choosing our number
            BacktrackSubsets(resultList, tempList, nums, start + 1);
        }


        public IList<IList<int>> GetSubsetsBinaryMethod(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            //Array.Sort(nums);
            for (int i = 0; i < Math.Pow(nums.Length, 2) - 1; i++)
            {
                list.Add(GenerateBinarySet(nums, i));
            }

            return list;
        }

        private IList<int> GenerateBinarySet(int[] nums, int binary)
        {
            var results = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {

                int bit = binary & 1;
                if (bit == 1)
                {
                    results.Add(nums[i]);
                }

                binary >>= 1; //Chops off right most bit
            }

            return results;

        }


    }
}
