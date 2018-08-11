using System;
using InterviewCakeProblems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void HasPalindromePermutation_TestExample_Success()
        {
            var testString = "civic";
            var expectedResult = true;

            var palindrome = new Palindrome();
            var result = palindrome.HasPalindromePermutation(testString);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void HasPalindromePermutation_TestExample_Fail()
        {
            var testString = "civil";
            var expectedResult = false;

            var palindrome = new Palindrome();
            var result = palindrome.HasPalindromePermutation(testString);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
