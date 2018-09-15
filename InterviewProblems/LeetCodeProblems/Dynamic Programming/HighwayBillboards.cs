using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Dynamic_Programming
{
    /// <summary>
    /// HackerRank Billboards
    /// https://www.hackerrank.com/challenges/billboards/problem
    /// https://algorithms.tutorialhorizon.com/dynamic-programming-highway-billboard-problem/
    /// </summary>
    public class HighwayBillboards
    {
        public int MaxRevenue(int[] billboard, int[] revenue, int distance, int milesRes)
        {
            //MR(i)  is Maximum Revenue generated for i miles in highway
            //MR(i) = Max{MR(i-6) + Revenue[i], MR[i-1]}
            int[] MR = new int[distance + 1];
            MR[0] = 0;

            //Next billboard which can be used will start from index 0 in billboard[]
            int nextBillBoard = 0;

            //example if milesRes = 5 miles then any 2 bill boards has to be more than
            //5 miles away so actually we can put at 6th mile so we can add one mile milesRes
            milesRes = milesRes + 1; // actual minimum distance can be between 2 billboards

            for (int i = 1; i <= distance; i++)
            {
                //check if all the billboards are not already placed
                if (nextBillBoard >= billboard.Length)
                {
                    //All the billboards are already placed
                    //for rest of the distance copy the previous optimal solution
                    MR[i] = MR[i - 1];
                    continue;
                }

                //check if we have billboard for that particular mile
                //if not then copy the optimal solution from i-1th mile
                if (billboard[nextBillBoard] != i)
                {
                    //we do not have billboard for this particular mile
                    MR[i] = MR[i - 1];
                }
                else
                {
                    //we do  have billboard for this particular mile
                    //now we have 2 options, either place the billboard or ignore it
                    //we will choose the optimal solution
                    if (i >= milesRes)
                    {
                        MR[i] = Math.Max(MR[i - milesRes] + revenue[nextBillBoard], MR[i - 1]);
                    }
                    else
                    {
                        //there are no billboard placed prior to ith mile
                        //we will just place the billboard
                        MR[i] = revenue[nextBillBoard];
                    }

                    nextBillBoard++;
                }
            }


            return MR[distance];
        }

    }
}
