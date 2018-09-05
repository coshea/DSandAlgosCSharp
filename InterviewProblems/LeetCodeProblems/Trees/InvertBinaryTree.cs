using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// Leetcode 226. Invert Binary Tree
    /// https://leetcode.com/problems/invert-binary-tree/description/
    /// Invert a binary tree.
    /// </summary>
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            Invert(root);

            return root;
        }

        private void Invert(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return;
            }

            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            if (root.left != null)
            {
                Invert(root.left);
            }
            if (root.right != null)
            {
                Invert(root.right);
            }
        }
    }
}
