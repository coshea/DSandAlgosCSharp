using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// 654. Maximum Binary Tree
    /// https://leetcode.com/problems/maximum-binary-tree/description/
    /// Given an integer array with no duplicates. A maximum tree building on this array is defined as follow:
    /// The root is the maximum number in the array.
    /// The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
    /// The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.
    /// Construct the maximum tree by the given array and output the root node of this tree.
    /// </summary>
    public class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructTree(nums, 0, nums.Length);

        }

        private TreeNode ConstructTree(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return null;
            }

            int maxNumIndex = FindMaxNumIndex(nums, left, right);

            TreeNode root = new TreeNode(nums[maxNumIndex]);

            root.left = ConstructTree(nums, left, maxNumIndex);
            root.right = ConstructTree(nums, maxNumIndex + 1, right);

            return root;
        }

        private int FindMaxNumIndex(int[] nums, int left, int right)
        {
            int maxNum = nums[left];
            int maxNumIndex = left;

            for (int i = left; i < right; i++)
            {
                if (nums[i] > maxNum)
                {
                    maxNum = nums[i];
                    maxNumIndex = i;
                }
            }

            return maxNumIndex;
        }



    }
}
