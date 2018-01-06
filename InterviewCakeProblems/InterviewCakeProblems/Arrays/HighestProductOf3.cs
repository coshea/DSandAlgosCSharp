using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    /// <summary>
    /// Problem #3
    /// Given an array of integers, find the highest product you can get from three of the integers.
    /// The input arrayOfInts will always have at least three integers.
    /// </summary>
    public class HighestProductOf3
    {
        public int GetHighestProductOf3(int[] arrayOfInts)
        {

            // We're going to start at the 3rd item (at index 2)
            // so pre-populate highests and lowests based on the first 2 items.
            // We could also start these as null and check below if they're set
            // but this is arguably cleaner
            int highestNum = Math.Max(arrayOfInts[0], arrayOfInts[1]);            
            int lowestNum = Math.Min(arrayOfInts[0], arrayOfInts[1]);

            // Except this one--we pre-populate it for the first *3* items.
            // This means in our first pass it'll check against itself, which is fine.
            int highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                // Do we have a new highest product of 3?
                // It's either the current highest,
                // or the current times the highest product of two
                // or the current times the lowest product of two
                highestProductOf3 = Math.Max(highestProductOf3
                    , Math.Max(current * highestProductOf2
                                , current * lowestProductOf2));

                highestProductOf2 = Math.Max(highestProductOf2
                    , Math.Max(current * highestNum
                                , current * lowestNum));

                lowestProductOf2 = Math.Min(lowestProductOf2
                    , Math.Min(current * highestNum
                                , current * lowestNum));

                highestNum = Math.Max(highestNum, current);
                lowestNum = Math.Min(lowestNum, current);


            }

            return highestProductOf3;
        }
    }
}
