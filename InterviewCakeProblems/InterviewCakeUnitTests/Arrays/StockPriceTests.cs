using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass]
    public class StockPriceTests
    {
        [TestMethod]
        public void StockPrice_TestExample()
        {
            int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9 };
            int expectedResult = 6;

            var pricer = new StockPrice();
            int result = pricer.GetMaxProfit(stockPricesYesterday);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void StockPrice_SamePrices()
        {
            int[] stockPricesYesterday = { 10, 10, 10, 10, 10, 10 };
            int expectedResult = 0;

            var pricer = new StockPrice();
            int result = pricer.GetMaxProfit(stockPricesYesterday);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void StockPrice_AllNegative()
        {
            int[] stockPricesYesterday = { 10, 9, 8, 6, 4, 1 };
            int expectedResult = -1;

            var pricer = new StockPrice();
            int result = pricer.GetMaxProfit(stockPricesYesterday);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
