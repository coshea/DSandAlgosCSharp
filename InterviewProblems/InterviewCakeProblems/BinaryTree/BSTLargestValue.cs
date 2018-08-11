using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.BinaryTree
{
    public class BSTLargestValueInefficient
    {
        public int FindLargestValue(BinaryTreeNode rootNode)
        {
            if (rootNode.Right != null)
            {
                return FindLargestValue(rootNode.Right);
            }

            return rootNode.Value;
        }

        /// <summary>
        /// It'll take O(h)O(h) time (where hh is the height of the tree) and O(h)O(h) space.
        /// But that h space in the call stack ↴ is avoidable
        /// </summary>
        /// <param name="rootNode"></param>
        /// <returns></returns>
        public int FindSecondLargestValue(BinaryTreeNode rootNode)
        {
            // Case: we're currently at largest, and largest has a left subtree,
            // so 2nd largest is largest in said subtree
            if (rootNode.Left != null && rootNode.Right == null)
            {
                return FindLargestValue(rootNode.Left);
            }

            // Case: we're at parent of largest, and largest has no left subtree,
            // so 2nd largest must be current node
            if (rootNode.Right != null && rootNode.Right.Left == null && rootNode.Right.Right == null)
            {
                return rootNode.Value;
            }

            // Otherwise: step right
            return FindSecondLargestValue(rootNode.Right);
        }
    }


    /// <summary>
    /// We're doing one walk down our BST, which means O(h)O(h) time, 
    /// where hh is the height of the tree (again, that's O(\lg{n})O(lgn) 
    /// if the tree is balanced, O(n)O(n) otherwise). O(1)O(1) space.
    /// </summary>
    public class BSTLargestValueEfficient
    {
        public int FindLargest(BinaryTreeNode rootNode)
        {
            var current = rootNode;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }

        public int FindSecondLargest(BinaryTreeNode rootNode)
        {
            if (rootNode == null
                || (rootNode.Left == null && rootNode.Right == null))
            {
                throw new ArgumentException("Tree must have at least 2 nodes",
                    nameof(rootNode));
            }

            var current = rootNode;

            while (true)
            {
                // Case: current is largest and has a left subtree
                // 2nd largest is the largest in that subtree
                if (current.Left != null && current.Right == null)
                {
                    return FindLargest(current.Left);
                }

                // Case: current is parent of largest, and largest has no children,
                // so current is 2nd largest
                if (current.Right != null
                    && current.Right.Left == null
                    && current.Right.Right == null)
                {
                    return current.Value;
                }

                current = current.Right;
            }
        }
    }
}
