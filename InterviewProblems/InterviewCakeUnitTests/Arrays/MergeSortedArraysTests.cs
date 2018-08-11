using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass()]
    public class MergeSortedArraysTests
    {
        [TestMethod()]
        public void MergeArraysTest()
        {
            int[] firstTestArray = { 3, 4, 6, 10, 11, 15 };
            int[] secondTestArray = { 1, 5, 8, 12, 14, 19 };

            int[] expectedArray = { 1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19 };

            var merger = new MergeSortedArrays();
            var result = merger.MergeArrays(firstTestArray, secondTestArray);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
                Assert.AreEqual(expectedArray[i], result[i]);
            }
        }
    }
}