using System;
using InterviewCakeProblems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        public void ReverseWords_ReverseWithHelpers_Success()
        {
            var inputString = "This is a test.";
            var expectString = "test. a is This";

            var reverse = new ReverseWords();
            var result = reverse.ReverseWithHelpers(inputString);

            Assert.AreEqual(expectString, result);
        }

        [TestMethod]
        public void ReverseWords_ReverseInPlace_Success()
        {
            var inputString = "This is a test.";
            var expectString = "test. a is This";

            var reverse = new ReverseWords();
            var result = reverse.ReverseInPlace(inputString);

            Assert.AreEqual(expectString, result);
        }
    }
}
