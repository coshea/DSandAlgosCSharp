using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    /// <summary>
    /// Leetcode 273. Integer to English Words
    /// https://leetcode.com/problems/integer-to-english-words/description/
    /// Convert a non-negative integer to its english words representation. 
    /// Given input is guaranteed to be less than 2^31 - 1.
    /// </summary>
    public class IntegerToEnglishWords
    {

        private Dictionary<int, string> wordMap = new Dictionary<int, string>()
        {
            { 0, ""},
           { 1, "One"},
           { 2, "Two"},
           { 3, "Three"},
           { 4, "Four"},
           { 5, "Five"},
           { 6, "Six"},
           { 7, "Seven"},
           { 8, "Eight"},
           { 9, "Nine"},
           { 10, "Ten"},
           { 11, "Eleven"},
           { 12, "Twelve"},
           { 13, "Thirteen"},
           { 14, "Fourteen"},
           { 15, "Fifteen"},
           { 16, "Sixteen"},
           { 17, "Seventeen"},
           { 18, "Eightteen"},
           { 19, "Nineteen"},
           { 20, "Twenty"},
           { 30, "Thirty"},
           { 40, "Forty"},
           { 50, "Fifty"},
           { 60, "Sixty"},
           { 70, "Seventy"},
           { 80, "Eighty"},
           { 90, "Ninety"},
        };


        public string NumberToWords(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }

            StringBuilder sb = new StringBuilder();


            Helper(num, sb);


            return sb.ToString();

        }

        private void Helper(int num, StringBuilder sb)
        {

            if (num >= 1000000000)
            {
                //billion
                sb.Append(wordMap[num / 1000000000]);
                sb.Append(" Billion ");
                Helper(num % 1000000000, sb);
            }

            else if (num >= 1000000)
            {
                //million
                sb.Append(wordMap[num / 1000000]);
                sb.Append(" Million ");
                Helper(num % 1000000, sb);
            }

            else if (num >= 1000)
            {
                //thousand
                Helper(num / 1000, sb);
                sb.Append(" Thousand ");
                Helper(num % 1000, sb);
            }

            else if (num >= 100)
            {
                //hundred
                sb.Append(wordMap[num / 100]);
                sb.Append(" Hundred ");
                Helper(num % 100, sb);
            }

            else if (num >= 10)
            {
                //tens
                sb.Append(wordMap[num / 10 * 10]);
                sb.Append(" ");
                Helper(num % 10, sb);
            }

            else if (num > 0)
            {
                //ones
                sb.Append(wordMap[num]);
            }

        }



    }
}
