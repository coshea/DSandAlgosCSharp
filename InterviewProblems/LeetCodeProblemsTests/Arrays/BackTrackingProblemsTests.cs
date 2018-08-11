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
    public class BackTrackingProblemsTests
    {
        [TestMethod()]
        public void SubsetsTest()
        {
            var tester = new BackTrackingProblems();

            var testInput = new int[] { 1, 2, 3 };
            var testSum = 2;
            var expectedResult = 8;

            var result = tester.GetSubsets(testInput);

            Assert.AreEqual(expectedResult, result.Count);
        }

        [TestMethod()]
        public void GetSubsetsBinaryMethodTest()
        {
            var tester = new BackTrackingProblems();

            var testInput = new int[] { 1, 2, 3 };
            var testSum = 2;
            var expectedResult = 8;

            var result = tester.GetSubsetsBinaryMethod(testInput);

            Assert.AreEqual(expectedResult, result.Count);
        }
    }
}