﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems
{
    public class Rectangle
    {
        // Coordinates of bottom left corner
        public int LeftX { get; set; }
        public int BottomY { get; set; }

        // Dimensions
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int leftX, int bottomY, int width, int height)
        {
            LeftX = leftX;
            BottomY = bottomY;
            Width = width;
            Height = height;
        }
    }

    public class RangeOverLap
    {
        public readonly int StartPoint;
        public readonly int Length;

        public RangeOverLap(int highestStartPoint, int overlapLength)
        {
            StartPoint = highestStartPoint;
            Length = overlapLength;
        }
    }

    /// <summary>
    /// Question #6 - 
    /// Write a method to find the rectangular intersection of two given love rectangles.
    /// </summary>
    public class RectangleIntersection
    {
        public Rectangle FindRectangularOverlap(Rectangle rect1, Rectangle rect2)
        {
            // Get the x and y overlap points and lengths
            RangeOverLap xOverlap = FindRangeOverlap(rect1.LeftX, rect1.Width, rect2.LeftX, rect2.Width);
            RangeOverLap yOverlap = FindRangeOverlap(rect1.BottomY, rect1.Height, rect2.BottomY, rect2.Height);

            // Return null rectangle if there is no overlap
            if (xOverlap.Length == 0 || yOverlap.Length == 0)
            {
                return new Rectangle();
            }

            return new Rectangle(
                xOverlap.StartPoint,
                yOverlap.StartPoint,
                xOverlap.Length,
                yOverlap.Length
            );
        }

        public RangeOverLap FindRangeOverlap(int point1, int length1, int point2, int length2)
        {
            // Find the highest start point and lowest end point.
            // The highest ("rightmost" or "upmost") start point is
            // the start point of the overlap.
            // The lowest end point is the end point of the overlap.
            int highestStartPoint = Math.Max(point1, point2);
            int lowestEndPoint = Math.Min(point1 + length1, point2 + length2);

            // Return empty overlap if there is no overlap
            if (highestStartPoint >= lowestEndPoint)
            {
                return new RangeOverLap(0, 0);
            }

            // Compute the overlap length
            int overlapWidth = lowestEndPoint - highestStartPoint;

            return new RangeOverLap(highestStartPoint, overlapWidth);
        }
    }
}
