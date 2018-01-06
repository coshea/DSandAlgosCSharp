using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Arrays;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass]
    public class HighestProductOf3Tests
    {
        [TestMethod]
        public void HighestProductOf3Tests_TestExample()
        {
            int[] testArray = { 1, 10, -5, 1, -100 };
            int expectedProduct = 5000;

            var highestProduct = new HighestProductOf3();
            var result = highestProduct.GetHighestProductOf3(testArray);

            Assert.AreEqual(expectedProduct, result);
        }
    }
}
