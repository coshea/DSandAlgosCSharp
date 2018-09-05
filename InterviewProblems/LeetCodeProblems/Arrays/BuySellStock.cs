using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    /// <summary>
    /// Leetcode 121. Best Time to Buy and Sell Stock
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// If you were only permitted to complete at most one transaction
    /// (i.e., buy one and sell one share of the stock), 
    /// design an algorithm to find the maximum profit.
    /// Note that you cannot sell a stock before you buy one.
    /// </summary>
    public class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = Math.Max(prices[1] - prices[0], 0);

            for (int i = 1; i < prices.Length; i++)
            {
                int currentPrice = prices[i];
                int currentProfit = currentPrice - minPrice;

                maxProfit = Math.Max(currentProfit, maxProfit);
                minPrice = Math.Min(minPrice, currentPrice);
            }

            return maxProfit;
        }
    }
}
