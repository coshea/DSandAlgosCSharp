using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// Leetcode 101. Symmetric Tree
    /// Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
    /// For example, this binary tree [1,2,2,3,4,4,3] is symmetric
    /// But the following [1,2,2,null,3,null,3] is not:
    /// </summary>
    public class SymmetricTree
    {
        public bool IsSymmetric_BFS(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode t1 = queue.Dequeue();
                TreeNode t2 = queue.Dequeue();

                if (t1 == null && t2 == null)
                {
                    continue;
                }

                if (t1 == null || t2 == null)
                {
                    return false;
                }

                if (t1.val != t2.val)
                {
                    return false;
                }

                queue.Enqueue(t1.left);
                queue.Enqueue(t2.right);
                queue.Enqueue(t1.right);
                queue.Enqueue(t2.left);
            }

            return true;

        }

        public bool IsSymmetric_Recursive(TreeNode root)
        {
            return IsSymmetric_Recursive_Loop(root, root);
        }

        private bool IsSymmetric_Recursive_Loop(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }

            if (t1 == null || t2 == null)
            {
                return false;
            }

            if (t1.val != t2.val)
            {
                return false;
            }

            return IsSymmetric_Recursive_Loop(t1.left, t2.right)
                && IsSymmetric_Recursive_Loop(t1.right, t2.left);
        }
    }
}
