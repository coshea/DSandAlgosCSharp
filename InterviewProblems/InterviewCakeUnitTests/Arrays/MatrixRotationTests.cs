using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeUnitTests.Arrays
{
    [TestClass()]
    public class MatrixRotationTests
    {
        [TestMethod()]
        public void RotateClockwiseTest()
        {
            int[,] testArray = new int[4, 4]
            {   { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 },
                { 13,14,15,16 }};

            var expectedArray = new int[4, 4]
            {   { 5,1,2,3, },
                { 9,10,6,4 },
                { 13,11,7,8 },
                { 14,15,16,12 }};

            var result = MatrixRotation.RotateClockwise(testArray);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(result[i, j] + " ");
                    Assert.AreEqual(expectedArray[i, j], result[i, j]);
                }
                Console.WriteLine();
            }

        }

        [TestMethod()]
        public void RotateCounterClockwiseTest()
        {
            int[,] testArray = new int[4, 4]
            {   { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 },
                { 13,14,15,16 }};

            var expectedArray = new int[4, 4]
            {   { 2,3,4,8 },
                { 1,7,11,12 },
                { 5,6,10,16 },
                { 9,13,14,15 }};

            var result = MatrixRotation.RotateCounterClockwise(testArray);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(result[i, j] + " ");
                    Assert.AreEqual(expectedArray[i, j], result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}