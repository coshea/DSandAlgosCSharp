using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems
{
    public class ProductOfOtherNumbers
    {
        /// <summary>
        /// Problem #2
        /// You have an array of integers, and for each index you want to find the 
        /// product of every integer except the integer at that index.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public int[] GetProductsOfAllIntsExceptAtIndex(int[] inputArray)
        {
            if (inputArray.Length < 2)
            {
                throw new ArgumentException(
                    "Getting the product of numbers at other indices requires at least 2 numbers",
                    nameof(inputArray));
            }

            // We make an array with the length of the input array to
            // hold our products
            int[] productsOfAllIntsExceptAtIndex = new int[inputArray.Length];

            // For each integer, we find the product of all the integers
            // before it, storing the total product so far each time
            int productSoFar = 1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                productsOfAllIntsExceptAtIndex[i] = productSoFar;
                productSoFar *= inputArray[i];
            }

            // For each integer, we find the product of all the integers
            // after it. since each index in products already has the
            // product of all the integers before it, now we're storing
            // the total product of all other integers
            productSoFar = 1;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                productsOfAllIntsExceptAtIndex[i] *= productSoFar;
                productSoFar *= inputArray[i];
            }

            return productsOfAllIntsExceptAtIndex;
        }
    }
}
