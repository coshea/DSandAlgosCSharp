using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.OverlappingSubproblems
{
    /// <summary>
    /// Leetcode #62. Unique Paths
    /// A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
    /// The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid(marked 'Finish' in the diagram below).
    /// How many possible unique paths are there?
    /// https://leetcode.com/problems/unique-paths/description/
    /// </summary>
    public class UniquePaths
    {
        public int UniquePathsRecursive(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            return UniquePathsRecursive(m - 1, n) + UniquePathsRecursive(m, n - 1);
        }

        public int UniquePathsDP(int m, int n)
        {
            if (m == 1 && n == 1)
            {
                return 1;
            }

            // Create a 2D table to store results 
            // of subproblems
            int[,] count = new int[m, n];

            // Count of paths to reach any cell in 
            // first column is 1
            for (int i = 0; i < m; i++)
                count[i, 0] = 1;

            // Count of paths to reach any cell in
            // first column is 1
            for (int j = 0; j < n; j++)
                count[0, j] = 1;


            // Calculate count of paths for other 
            // cells in bottom-up manner using
            // the recursive solution
            for (int r = 1; r < m; r++)
            {
                for (int c = 1; c < n; c++)
                {
                    count[r, c] = count[r - 1, c] + count[r, c - 1];
                    // if the diagonal Movements are allowed
                    //+ count[i-1][j-1];  
                }
            }

            return count[m - 1, n - 1];
        }

        public int UniquePathsDP2(int m, int n)
        {
            int[,] count = new int[m, n];
            count[0, 0] = 1;

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (r - 1 >= 0)
                    {
                        count[r, c] += count[r - 1, c];
                    }
                    if (c - 1 >= 0)
                    {
                        count[r, c] += count[r, c - 1];
                    }
                }
            }

            return count[m - 1, n - 1];
        }
    }
}
