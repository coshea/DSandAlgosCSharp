using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    public class ClosestTreeValue
    {
        /// <summary>
        /// Leetcode #270. Closest Binary Search Tree Value
        /// Given a non-empty binary search tree and a target value, 
        /// find the value in the BST that is closest to the target.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ClosestValue(TreeNode root, double target)
        {
            double closestDiff = int.MaxValue;
            int closestNode = root.val;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                var diff = node.val - target;

                if (Math.Abs(diff) < closestDiff)
                {
                    closestDiff = Math.Abs(diff);
                    closestNode = node.val;
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }
                if (node.right != null)
                {
                    stack.Push(node.right);
                }

            }

            return closestNode;
        }
    }
}
