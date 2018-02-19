using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.HashSets
{
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
