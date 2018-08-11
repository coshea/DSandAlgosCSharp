using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings.Tests
{
    [TestClass()]
    public class ReverseWordsInAStringTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            char[] str = { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            char[] expected = { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', ' ', 't', 'h', 'e' };

            var tester = new ReverseWordsInAString();
            CollectionAssert.AreEqual(expected, tester.ReverseWords(str));
        }
    }
}