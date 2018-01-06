using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InterviewCakeProblems;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass]
    public class HiCalTests
    {
        [TestMethod]
        public void HiCalMergeRanges_TestExample()
        {
            var testCal = new List<Meeting>() { new Meeting(1, 3), new Meeting(2, 4) };
            var expected = new List<Meeting>() { new Meeting(1, 4) };

            HiCal hiCal = new HiCal();
            var result = hiCal.MergeRanges(testCal);

            Assert.AreEqual(expected[0].StartTime, result[0].StartTime);
            Assert.AreEqual(expected[0].EndTime, result[0].EndTime);
        }
    }
}
