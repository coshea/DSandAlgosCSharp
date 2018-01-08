using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    /// <summary>
    /// Question #5 - Write a method that, given:
    ///  1. an amount of money
    ///  2. an array of coin denominations
    ///  computes the number of ways to make the amount of money with coins of the available denominations.
    /// </summary>
    public class CoinDenominations
    {
        private Dictionary<string, int> _memo = new Dictionary<string, int>();

        /// <summary>
        /// Recursive Method & Memoize
        /// </summary>
        /// <param name="amountLeft"></param>
        /// <param name="denominations"></param>
        /// <param name="currentIndex"></param>
        /// <returns></returns>
        public int ChangePossibilitiesTopDown(int amountLeft, int[] denominations, int currentIndex = 0)
        {
            // Check our memo and short-circuit if we've already solved this one
            string memoKey = $"{amountLeft}, {currentIndex}";
            if (_memo.ContainsKey(memoKey))
            {
                Console.WriteLine($"grabbing memo [{memoKey}]");
                return _memo[memoKey];
            }

            // Base cases:
            // We hit the amount spot on. Yes!
            if (amountLeft == 0)
            {
                return 1;
            }

            // We overshot the amount left (used too many coins)
            if (amountLeft < 0)
            {
                return 0;
            }

            // We're out of denominations
            if (currentIndex == denominations.Length)
            {
                return 0;
            }

            // Print out actual part of array
            Console.Write($"checking ways to make {amountLeft} with ");
            Console.WriteLine($"[{string.Join(", ", denominations.Skip(currentIndex).Take(denominations.Length - currentIndex))}]");

            // Choose a current coin
            int currentCoin = denominations[currentIndex];

            // See how many possibilities we can get
            // for each number of times to use currentCoin
            int numPossibilities = 0;
            while (amountLeft >= 0)
            {
                numPossibilities += ChangePossibilitiesTopDown(amountLeft, denominations, currentIndex + 1);
                amountLeft -= currentCoin;
            }

            // Save the answer in our memo, so we don't compute it again
            _memo.Add(memoKey, numPossibilities);
            return numPossibilities;
        }


        public int ChangePossibilitiesBottomUp(int amount, int[] denominations)
        {
            int[] waysOfDoingNCents = new int[amount + 1];  // Array of zeros from 0..amount
            waysOfDoingNCents[0] = 1;

            foreach (int coin in denominations)
            {
                for (int higherAmount = coin; higherAmount <= amount; higherAmount++)
                {
                    int higherAmountRemainder = higherAmount - coin;
                    waysOfDoingNCents[higherAmount] += waysOfDoingNCents[higherAmountRemainder];
                }
            }

            return waysOfDoingNCents[amount];
        }
    }
}
