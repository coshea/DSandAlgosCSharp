using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class IntegerToEnglishWords
    {

        /// <summary>
        /// 273. Integer to English Words
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string NumberToWords(int num)
        {
            //In complete
            return IntToWord(num);
        }


        private string IntToWord(int num)
        {
            switch (num)
            {
                case 0:
                    return "";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "";
            }

        }
    }
}
