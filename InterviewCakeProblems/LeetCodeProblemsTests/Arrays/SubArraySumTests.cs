using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    [TestClass()]
    public class SubArraySumTests
    {
        [TestMethod()]
        public void SubarraySumTest_Example1()
        {
            var tester = new SubArraySum();

            var testInput = new int[] { 1, 1, 1 };
            var testSum = 2;
            var expectedResult = 2;

            Assert.AreEqual(expectedResult, tester.SubarraySum(testInput, testSum));
        }

        [TestMethod()]
        public void SubarraySumTest_Example2()
        {
            var tester = new SubArraySum();

            var testInput = new int[] { 1, 2, 3 };
            var testSum = 3;
            var expectedResult = 2;

            // Assert.AreEqual(expectedResult, tester.SubarraySum(testInput, testSum));
        }
    }
}