using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.HashSets
{
    /// <summary>
    /// Question #14
    /// Write a method that takes an integer flightLength (in minutes) 
    /// and an array of integers movieLengths (in minutes) 
    /// and returns a boolean indicating whether there are two numbers 
    /// in movieLengths whose sum equals flightLength.
    /// </summary>
    public class InFlightEntertainment
    {
        public bool CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            var movieLengthsSeen = new HashSet<int>();

            foreach (int firstMovieLength in movieLengths)
            {
                int matchingSecondMovieLength = flightLength - firstMovieLength;
                if (movieLengthsSeen.Contains(matchingSecondMovieLength))
                {
                    return true;
                }

                movieLengthsSeen.Add(firstMovieLength);
            }

            return false;
        }
    }
}
