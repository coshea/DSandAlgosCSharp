using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Trie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trie
{
    [TestClass()]
    public class TrieImplementationTests
    {
        [TestMethod()]
        public void TrieImplementationTest()
        {
            TrieImplementation trie = new TrieImplementation();

            trie.Insert("apple");
            Assert.IsTrue(trie.Search("apple"));   // returns true

            Assert.IsFalse(trie.Search("app"));     // returns false

            Assert.IsTrue(trie.StartsWith("app")); // returns true

            trie.Insert("app");
            Assert.IsTrue(trie.Search("app"));     // returns true
        }

    }
}