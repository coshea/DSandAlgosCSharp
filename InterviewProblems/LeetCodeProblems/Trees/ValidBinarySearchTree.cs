using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    public class TreeNodeBounds
    {
        public int LowerBound;
        public int UpperBound;
        public TreeNode Node;
        public TreeNodeBounds(TreeNode node, int lowerBound, int upperBound)
        {
            Node = node;
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }
    }

    public class ValidBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;

            Stack<TreeNodeBounds> stack = new Stack<TreeNodeBounds>();
            stack.Push(new TreeNodeBounds(root, int.MinValue, int.MaxValue));

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.Node.val >= node.UpperBound || node.Node.val <= node.LowerBound)
                    return false;

                if (node.Node.left != null)
                    stack.Push(new TreeNodeBounds(node.Node.left, node.LowerBound, node.Node.val));

                if (node.Node.right != null)
                    stack.Push(new TreeNodeBounds(node.Node.right, node.Node.val, node.UpperBound));

            }


            return true;
        }
    }
}
