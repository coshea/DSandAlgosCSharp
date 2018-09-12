using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays.Tests
{
    [TestClass()]
    public class IntegerToEnglishWordsTests
    {
        [TestMethod()]
        public void NumberToWordsTest_123()
        {
            int input = 123;
            string expected = "One Hundred Twenty Three";

            var tester = new IntegerToEnglishWords();

            Assert.AreEqual(expected, tester.NumberToWords(input));
        }

        [TestMethod()]
        public void NumberToWordsTest_12345()
        {
            int input = 12345;
            string expected = "Twelve Thousand Three Hundred Forty Five";

            var tester = new IntegerToEnglishWords();

            Assert.AreEqual(expected, tester.NumberToWords(input));
        }

        [TestMethod()]
        public void NumberToWordsTest_1234567()
        {
            int input = 1234567;
            string expected = "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven";

            var tester = new IntegerToEnglishWords();

            Assert.AreEqual(expected, tester.NumberToWords(input));
        }

        [TestMethod()]
        public void NumberToWordsTest_1234567891()
        {
            int input = 1234567891;
            string expected = "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One";

            var tester = new IntegerToEnglishWords();

            Assert.AreEqual(expected, tester.NumberToWords(input));
        }
    }
}