using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class Permutations
    {
        /// <summary>
        /// Problem #31
        /// Write a recursive method for generating all permutations of an input string.
        /// Return them as a set.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public ISet<string> GetPermutations(string inputString)
        {
            // Base case
            if (inputString.Length <= 1)
            {
                return new HashSet<string>(inputString.Select(c => new string(c, 1)));
            }


            var allCharsExceptLast = inputString.Substring(0, inputString.Length - 1);
            char lastChar = inputString[inputString.Length - 1];

            // Recursive call: get all possible permutations for all chars except last
            var permutationsOfAllCharsExceptLast = GetPermutations(allCharsExceptLast);

            // Put the last char in all possible positions for each of the above permutations
            var permutations = new HashSet<string>();
            foreach (var permutationOfAllCharsExceptLast in permutationsOfAllCharsExceptLast)
            {
                for (int position = 0; position <= allCharsExceptLast.Length; position++)
                {
                    var permutation = permutationOfAllCharsExceptLast.Substring(0, position)
                        + lastChar
                        + permutationOfAllCharsExceptLast.Substring(position);
                    permutations.Add(permutation);
                }
            }

            return permutations;
        }
    }
}
