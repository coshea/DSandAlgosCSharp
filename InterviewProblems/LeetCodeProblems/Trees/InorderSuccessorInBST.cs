using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    /// <summary>
    /// Leetcode 285. Inorder Successor in BST
    /// https://leetcode.com/problems/inorder-successor-in-bst/description/
    /// iven a binary search tree and a node in it, find the in-order successor of that node in the BST.
    /// Note: If the given node has no in-order successor in the tree, return null.
    /// </summary>
    /// <remarks>Solution doesn't answer this question</remarks>
    public class InorderSuccessorInBST
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            Stack<TreeNode> searchStack = new Stack<TreeNode>();
            Stack<TreeNode> predStack = new Stack<TreeNode>();

            searchStack.Push(root);
            predStack.Push(null);

            while (searchStack.Count > 0)
            {
                var node = searchStack.Pop();
                var predNode = predStack.Pop();

                if (node.val == p.val)
                {
                    return predNode;
                }

                if (node.left != null)
                {
                    searchStack.Push(node.left);
                    predStack.Push(node);
                }
                if (node.right != null)
                {
                    searchStack.Push(node.right);
                    predStack.Push(node);
                }
            }

            return null;
        }
    }
}