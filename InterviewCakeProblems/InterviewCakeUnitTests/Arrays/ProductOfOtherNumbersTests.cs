using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass()]
    public class ProductOfOtherNumbersTests
    {
        [TestMethod()]
        public void GetProductsOfAllIntsExceptAtIndexTest_TestExample()
        {
            int[] testArray = new int[] { 1, 7, 3, 4 };
            int[] expectedArray = new int[] { 84, 12, 28, 21 };

            var tester = new ProductOfOtherNumbers();
            var result = tester.GetProductsOfAllIntsExceptAtIndex(testArray);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], result[i]);
            }

        }
    }
}