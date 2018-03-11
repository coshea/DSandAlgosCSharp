using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.BinaryTree
{
    public class TreeLinkNode
    {
        public int Value { get; }

        public TreeLinkNode Left { get; set; }

        public TreeLinkNode Right { get; set; }

        public TreeLinkNode NextRight { get; set; }

        public TreeLinkNode(int value)
        {
            Value = value;
        }

    }

    public class ConnectNodes
    {
        public void Connect(TreeLinkNode root)
        {
            Queue<TreeLinkNode> queue = new Queue<TreeLinkNode>();

            queue.Enqueue(root);
            queue.Enqueue(null);

            while (queue.Count > 0)
            {
                TreeLinkNode node = queue.Dequeue();

                if (node != null)
                {
                    node.NextRight = queue.Peek();

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    else if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
                else if (queue.Count != 0)
                {
                    queue.Enqueue(null);
                }
            }
        }
    }
}
