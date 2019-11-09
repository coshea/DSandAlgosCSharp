using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode(int _val, TreeNode _left, TreeNode _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
