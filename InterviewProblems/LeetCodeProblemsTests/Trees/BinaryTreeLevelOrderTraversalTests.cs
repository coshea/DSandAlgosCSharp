using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees.Tests
{
    [TestClass()]
    public class BinaryTreeLevelOrderTraversalTests
    {
        [TestMethod()]
        public void LevelOrderTest()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var tester = new BinaryTreeLevelOrderTraversal();
            var result = tester.LevelOrder_DFS(root);

            Assert.AreEqual(3, result[0][0]);
            Assert.AreEqual(9, result[1][0]);
            Assert.AreEqual(20, result[1][1]);
            Assert.AreEqual(15, result[2][0]);
            Assert.AreEqual(7, result[2][1]);
        }
    }
}