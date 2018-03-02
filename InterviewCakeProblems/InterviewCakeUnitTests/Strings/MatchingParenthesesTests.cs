using System;
using InterviewCakeProblems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass]
    public class MatchingParenthesesTests
    {
        [TestMethod]
        public void GetClosingParentheses_TestExample_Success()
        {
            var message = @"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";
            var startPosition = 10;
            var expectPosition = 79;

            var matcher = new MatchingParentheses();
            var result = matcher.GetClosingParentheses(message, startPosition);

            Assert.AreEqual(expectPosition, result);
        }
    }
}
