using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.HashSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.HashSets
{
    [TestClass()]
    public class TopKMostFrequentElementsTests
    {
        [TestMethod()]
        public void TopKFrequentTest()
        {
            var tester = new TopKMostFrequentElements();

            var testInput = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var expectedResult = new int[] { 1, 2 };
            var result = tester.TopKFrequent(testInput, k);

            Assert.AreEqual(expectedResult.Length, result.Count);
            Assert.AreEqual(expectedResult[0], result[0]);
        }
    }
}