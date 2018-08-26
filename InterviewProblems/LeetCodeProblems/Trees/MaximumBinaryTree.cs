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
            int maxNumIndex = FindMaxNumIndex(nums);
            TreeNode root = new TreeNode(nums[maxNumIndex]);

            List<int> left = nums.Take(maxNumIndex - 1).ToList();
            List<int> right = nums.Skip(maxNumIndex + 1).ToList();


            if (left.Count > 0)
            {
                left.Sort();
                root.left = new TreeNode(left[0]);
                ConstructTree(root.left, left, 1);
            }

            if (right.Count > 0)
            {
                right.Sort();
                ConstructTree(root.right, right, 1);
                root.right = new TreeNode(right[0]);
            }

            return root;

        }

        private int FindMaxNumIndex(int[] nums)
        {
            int maxNum = nums[0];
            int maxNumIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxNum)
                {
                    maxNum = nums[i];
                    maxNumIndex = i;
                }
            }

            return maxNumIndex;
        }


        private void ConstructTree(TreeNode root, List<int> left, int index)
        {
            if (left.Count <= index)
            {
                return;
            }



            //index++
        }
    }
}
