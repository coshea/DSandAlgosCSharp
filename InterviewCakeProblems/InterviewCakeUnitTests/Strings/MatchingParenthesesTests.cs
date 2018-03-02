using System;
using InterviewCakeProblems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass]
    public class MatchingParenthesesTests
    {
        [TestMethod]
        public void MatchingParentheses_GetClosingParentheses_TestExample_Success()
        {
            var message = @"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";
            var startPosition = 10;
            var expectPosition = 79;

            var matcher = new MatchingParentheses();
            var result = matcher.GetClosingParentheses(message, startPosition);

            Assert.AreEqual(expectPosition, result);
        }

        [TestMethod]
        public void MatchingParentheses_IsBalancedCode_False()
        {
            var message = "{ [ ( ] ) }";

            var matcher = new MatchingParentheses();
            var result = matcher.IsBalancedCode(message);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MatchingParentheses_IsBalancedCode_True()
        {
            var message = "{ ( [ words ] ) }";

            var matcher = new MatchingParentheses();
            var result = matcher.IsBalancedCode(message);

            Assert.IsTrue(result);
        }
    }
}
