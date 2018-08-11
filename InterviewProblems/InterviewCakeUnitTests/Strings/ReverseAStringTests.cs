using System;
using InterviewCakeProblems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass]
    public class ReverseAStringTests
    {
        [TestMethod]
        public void ReverseAString_ReverseWithLoop_Success()
        {
            var inputString = "This is a test.";
            var expectString = ".tset a si sihT";

            var reverse = new ReverseAString();
            var result = reverse.Reverse(inputString);

            Assert.AreEqual(expectString, result);
        }

        [TestMethod]
        public void ReverseAString_ReverseWithStack_Success()
        {
            var inputString = "This is a test.";
            var expectString = ".tset a si sihT";

            var reverse = new ReverseAString();
            var result = reverse.ReverseWithStack(inputString);

            Assert.AreEqual(expectString, result);
        }
    }
}
