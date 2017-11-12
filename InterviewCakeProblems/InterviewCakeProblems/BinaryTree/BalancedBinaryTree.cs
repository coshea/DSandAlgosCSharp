using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.BinaryTree
{
    public class NodeDepthPair
    {
        public BinaryTreeNode Node { get; }

        public int Depth { get; }

        public NodeDepthPair(BinaryTreeNode node, int depth)
        {
            Node = node;
            Depth = depth;
        }
    }

    public class BalancedBinaryTree
    {
        public bool IsSuperBalanced(BinaryTreeNode treeRoot)
        {

            if (treeRoot == null)
                return true;

            var depths = new List<int>(3);

            var nodes = new Stack<NodeDepthPair>();
            nodes.Push(new NodeDepthPair(treeRoot, 0));


            while (nodes.Count > 0)
            {
                // Pop a node and its depth from the top of our stack
                var nodeDepthPair = nodes.Pop();
                var node = nodeDepthPair.Node;
                var depth = nodeDepthPair.Depth;

                // Case: we found a leaf
                if (node.Left == null && node.Right == null)
                {
                    // We only care if it's a new depth
                    if (!depths.Contains(depth))
                    {
                        depths.Add(depth);

                        // Two ways we might now have an unbalanced tree:
                        //   1) more than 2 different leaf depths
                        //   2) 2 leaf depths that are more than 1 apart
                        if (depths.Count > 2 || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }

                // Case: this isn't a leaf - keep stepping down
                else
                {
                    if (node.Left != null)
                        nodes.Push(new NodeDepthPair(node.Left, depth + 1));

                    if (node.Right != null)
                        nodes.Push(new NodeDepthPair(node.Right, depth + 1));
                }
                
            }


            return true;
        }
    }
}
