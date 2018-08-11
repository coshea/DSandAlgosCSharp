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
    public class MapSumTests
    {
        [TestMethod()]
        public void MapSumTest1()
        {
            MapSum trie = new MapSum();

            trie.Insert("apple", 3);
            Assert.AreEqual(3, trie.Sum("ap"));

            trie.Insert("app", 2);
            Assert.AreEqual(5, trie.Sum("ap"));

        }

        [TestMethod()]
        public void MapSumTest2()
        {
            MapSum trie = new MapSum();

            trie.Insert("apple", 3);
            Assert.AreEqual(3, trie.Sum("apple"));

            trie.Insert("app", 2);
            Assert.AreEqual(5, trie.Sum("ap"));

        }

        [TestMethod()]
        public void MapSumTest3()
        {
            MapSum trie = new MapSum();

            trie.Insert("aa", 3);
            Assert.AreEqual(3, trie.Sum("a"));

            trie.Insert("ab", 2);
            Assert.AreEqual(5, trie.Sum("a"));

        }

        [TestMethod()]
        public void MapSumTest4()
        {
            MapSum trie = new MapSum();

            trie.Insert("aa", 3);
            Assert.AreEqual(3, trie.Sum("a"));

            trie.Insert("aa", 2);
            Assert.AreEqual(2, trie.Sum("a"));

        }
    }
}