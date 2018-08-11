using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trees
{

    public class NumberOfIslands
    {
        /// <summary>
        /// 200. Number of Islands
        /// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
        /// An island is surrounded by water and is formed by connecting adjacent lands 
        /// horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
        /// </summary>
        public int NumIslands_DFS(char[,] grid)
        {
            int islands = 0;
            int numRows = grid.GetLength(0);
            int numCols = grid.GetLength(1);

            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < numCols; c++)
                {
                    if (grid[r, c] == '1')
                    {
                        islands++;
                        DFS(grid, r, c);
                    }
                }
            }

            return islands;
        }

        private void DFS(char[,] grid, int row, int col)
        {
            int numRows = grid.GetLength(0);
            int numCols = grid.GetLength(1);

            if (row < 0 || col < 0 || row >= numRows || col >= numCols || grid[row, col] == '0')
            {
                return;
            }

            grid[row, col] = '0';
            DFS(grid, row - 1, col);
            DFS(grid, row + 1, col);
            DFS(grid, row, col - 1);
            DFS(grid, row, col + 1);

        }
    }
}
