using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// Leetcode 102. Binary Tree Level Order Traversal
    /// Given a binary tree, return the level order traversal of its nodes' values. 
    /// (ie, from left to right, level by level).
    /// </summary>
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder_DFS(TreeNode root)
        {
            var levels = new List<IList<int>>();

            if (root == null)
            {
                return levels;
            }

            DFS(levels, root, 0);

            return levels;
        }

        private void DFS(List<IList<int>> levels, TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }

            if (levels.Count <= level)
            {
                levels.Add(new List<int>());
            }

            var subLevel = levels[level];
            subLevel.Add(root.val);

            int nextLevel = level + 1;

            if (root.left != null)
            {
                DFS(levels, root.left, nextLevel);
            }
            if (root.right != null)
            {
                DFS(levels, root.right, nextLevel);
            }
        }
    }
}
