using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    /// <summary>
    /// Problem $43
    /// We have our lists of orders sorted numerically already, in arrays. 
    /// Write a method to merge our arrays of orders into one sorted array.
    /// </summary>
    public class MergeSortedArrays
    {
        public int[] MergeArrays(int[] firstArray, int[] secondArray)
        {
            int[] mergedArray = new int[firstArray.Length + secondArray.Length];

            int firstIndex = 0;
            int secondIndex = 0;
            int mergedIndex = 0;

            while (firstIndex < firstArray.Length || secondIndex < secondArray.Length)
            {
                if (firstIndex < firstArray.Length && firstArray[firstIndex] <= secondArray[secondIndex])
                {
                    mergedArray[mergedIndex] = firstArray[firstIndex];
                    firstIndex++;
                }
                else if (secondIndex < secondArray.Length)
                {
                    mergedArray[mergedIndex] = secondArray[secondIndex];
                    secondIndex++;
                }

                mergedIndex++;
            }


            return mergedArray;
        }
    }
}
