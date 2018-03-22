using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    [TestClass()]
    public class KthElementTests
    {
        [TestMethod()]
        public void GetKthLargestestUsingSortAndListTest()
        {
            var testArray = new int[] { 3, 2, 2, 1, 5, 6, 6, 4 };
            var k = 2;
            var expectValue = 5;

            var tester = new KthElement();
            Assert.AreEqual(expectValue, tester.GetKthLargestUsingLinqSortAndList(testArray, k));
        }

        [TestMethod()]
        public void GetKthLargestUsingSortedListTest()
        {
            var testArray = new int[] { 3, 2, 2, 1, 5, 6, 6, 4 };
            var k = 3;
            var expectValue = 4;

            var tester = new KthElement();
            Assert.AreEqual(expectValue, tester.GetKthLargestUsingSortedList(testArray, k));
        }
    }
}