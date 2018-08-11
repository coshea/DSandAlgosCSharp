using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems
{
    /// <summary>
    /// Suppose we could access yesterday's stock prices as an array, where:
    ///    The indices are the time in minutes past trade opening time, which was 9:30am local time.
    ///    The values are the price in dollars of Apple stock at that time.
    ///    So if the stock cost $500 at 10:30am, stockPricesYesterday[60] = 500.
    /// Write an efficient method that takes stockPricesYesterday and returns the best profit 
    /// I could have made from 1 purchase and 1 sale of 1 Apple stock yesterday.
    /// </summary>
    public class StockPrice
    {
        public int GetMaxProfit(int[] stockPricesYesterday)
        {
            if (stockPricesYesterday.Length < 2)
            {
                throw new ArgumentException("Getting a profit requires at least 2 prices",
                    nameof(stockPricesYesterday));
            }

            int minPrice = stockPricesYesterday[0];
            int maxProfit = stockPricesYesterday[1] - stockPricesYesterday[0];

            for (int i = 1; i < stockPricesYesterday.Length; i++)
            {
                int currentPrice = stockPricesYesterday[i];

                int currentProfit = currentPrice - minPrice;

                maxProfit = Math.Max(maxProfit, currentProfit);

                minPrice = Math.Min(minPrice, currentPrice);
                
            }
                                   
            return maxProfit;
        }
    }
}
