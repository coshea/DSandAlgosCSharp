using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// Leetcode 129. Sum Root to Leaf Numbers
    /// Given a binary tree containing digits from 0-9 only, 
    /// each root-to-leaf path could represent a number.
    /// An example is the root-to-leaf path 1->2->3 which represents the number 123.
    /// Find the total sum of all root-to-leaf numbers.
    /// </summary>
    public class SumRootToLeaf
    {
        private int _totalSum;
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            DepthFirstSum(root, 0);
            return _totalSum;
        }

        private void DepthFirstSum(TreeNode root, int leafToRootSum)
        {
            int newLeafSum = leafToRootSum * 10;
            newLeafSum += root.val;

            if (root.left == null && root.right == null)
            {
                _totalSum += newLeafSum;
            }

            if (root.left != null)
            {
                DepthFirstSum(root.left, newLeafSum);
            }
            if (root.right != null)
            {
                DepthFirstSum(root.right, newLeafSum);
            }
        }
    }
}
