using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    public static class MatrixRotation
    {
        public static int[,] RotateClockwise(int[,] matrix)
        {
            int[,] rotatedMatrix = matrix;
            int rowIndex = 0;
            int colIndex = 0;
            int rowEnd = matrix.GetLength(0);
            int colEnd = matrix.GetLength(1);
            int prev = 0;
            int curr = 0;


            while (rowIndex < rowEnd && colIndex < colEnd)
            {
                if (rowIndex + 1 == rowEnd || colIndex + 1 == colEnd)
                {
                    break;
                }

                // Store the first element of next row, this
                // element will replace first element of current row
                prev = rotatedMatrix[rowIndex + 1, colIndex];

                //Move elements of top row.
                for (int i = colIndex; i < colEnd; i++)
                {
                    curr = rotatedMatrix[rowIndex, i];
                    rotatedMatrix[rowIndex, i] = prev;
                    prev = curr;
                }
                rowIndex++;

                //Move elements of last column.
                for (int i = rowIndex; i < rowEnd; i++)
                {
                    curr = rotatedMatrix[i, colEnd - 1];
                    rotatedMatrix[i, colEnd - 1] = prev;
                    prev = curr;
                }
                colEnd--;

                // Move elements of bottom row.
                if (rowIndex < rowEnd)
                {
                    for (int i = colEnd - 1; i >= colIndex; i--)
                    {
                        curr = rotatedMatrix[rowEnd - 1, i];
                        rotatedMatrix[rowEnd - 1, i] = prev;
                        prev = curr;
                    }
                }
                rowEnd--;

                //Move elements of first column.
                if (colIndex < colEnd)
                {
                    for (int i = rowEnd - 1; i >= rowIndex; i--)
                    {
                        curr = rotatedMatrix[i, colIndex];
                        rotatedMatrix[i, colIndex] = prev;
                        prev = curr;
                    }
                }
                colIndex++;
            }
            return rotatedMatrix;
        }

        public static int[,] RotateCounterClockwise(int[,] matrix)
        {
            int[,] rotatedMatrix = matrix;
            int rowIndex = 0;
            int colIndex = 0;
            int rowEnd = matrix.GetLength(0);
            int colEnd = matrix.GetLength(1);
            int prev = 0;
            int curr = 0;

            while (rowIndex < rowEnd && colIndex < colEnd)
            {
                if (rowIndex + 1 == rowEnd || colIndex + 1 == colEnd)
                {
                    break;
                }

                prev = rotatedMatrix[rowIndex, colIndex + 1];

                // Move first column
                for (int i = rowIndex; i < rowEnd; i++)
                {
                    curr = rotatedMatrix[i, colIndex];
                    rotatedMatrix[i, colIndex] = prev;
                    prev = curr;
                }
                colIndex++;

                //Move bottom row
                for (int i = colIndex; i < colEnd; i++)
                {
                    curr = rotatedMatrix[rowEnd - 1, i];
                    rotatedMatrix[rowEnd - 1, i] = prev;
                    prev = curr;
                }
                rowEnd--;

                // Move farthest right column
                if (colIndex < colEnd)
                {
                    for (int i = rowEnd - 1; i >= rowIndex; i--)
                    {
                        curr = rotatedMatrix[i, colEnd - 1];
                        rotatedMatrix[i, colEnd - 1] = prev;
                        prev = curr;
                    }

                }
                colEnd--;

                // Move top most row
                if (rowIndex < rowEnd)
                {
                    for (int i = colEnd - 1; i >= colIndex; i--)
                    {
                        curr = rotatedMatrix[rowIndex, i];
                        rotatedMatrix[rowIndex, i] = prev;
                        prev = curr;
                    }
                }
                rowIndex++;

            }

            return rotatedMatrix;
        }

    }
}
