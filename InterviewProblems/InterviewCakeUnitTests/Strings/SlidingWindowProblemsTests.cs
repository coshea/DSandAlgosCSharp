using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeUnitTests.Strings
{
    [TestClass()]
    public class SlidingWindowProblemsTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            var testString = "abcabcbb";

            var expected = 3;

            var tester = new SlidingWindowProblems();

            Assert.AreEqual(expected, tester.LengthOfLongestSubstring(testString));
        }
    }
}