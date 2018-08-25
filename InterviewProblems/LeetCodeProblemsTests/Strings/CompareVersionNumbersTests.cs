using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Strings.Tests
{
    [TestClass()]
    public class CompareVersionNumbersTests
    {
        [TestMethod()]
        public void CompareVersionTest_TestExample1()
        {
            int expected = -1;
            string v1 = "0.1";
            string v2 = "1.1";
            var tester = new CompareVersionNumbers();

            Assert.AreEqual(expected, tester.CompareVersion(v1, v2));
        }

        [TestMethod()]
        public void CompareVersionTest_TestExample2()
        {
            int expected = 1;
            string v1 = "1.0.1";
            string v2 = "1";
            var tester = new CompareVersionNumbers();

            Assert.AreEqual(expected, tester.CompareVersion(v1, v2));
        }
    }
}