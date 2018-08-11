using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Arrays
{
    /// <summary>
    /// Leetcode #215. Kth Largest Element in an Array
    /// Find the kth largest element in an unsorted array. 
    /// Note that it is the kth largest element in the sorted order, 
    /// not the kth distinct element.
    /// </summary>
    public class KthElement
    {
        public int GetKthLargestUsingLinqSortAndList(int[] array, int k)
        {
            var sortedList = array.ToList().OrderByDescending(i => i);

            var max = Int32.MaxValue;

            foreach (var value in sortedList)
            {
                if (value < max)
                {
                    max = value;
                    k--;
                }
                if (k == 0)
                {
                    return max;
                }
            }

            return -1;

        }

        public int GetKthLargestUsingSort(int[] array, int k)
        {
            QuickSortArray(array);

            var max = Int32.MaxValue;

            foreach (var value in array)
            {
                if (value < max)
                {
                    max = value;
                    k--;
                }
                if (k == 0)
                {
                    return max;
                }
            }

            return -1;

        }

        private void QuickSortArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid = (right - left) / 2;



        }

        /// <summary>
        /// Only does unique values
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int GetKthLargestUsingSortedList(int[] array, int k)
        {
            //Array.Sort(array, (x, y) => x.CompareTo(y)); // ascending
            //Array.Sort(array, (x, y) => y.CompareTo(x)); // descending

            Comparer<int> comparer = Comparer<int>.Create((a, b) => b.CompareTo(a)); //descending

            SortedSet<int> sortedList = new SortedSet<int>(array, comparer);

            var max = Int32.MaxValue;

            foreach (var value in sortedList)
            {
                if (value < max)
                {
                    max = value;
                    k--;
                }
                if (k == 0)
                {
                    return max;
                }
            }

            return -1;
        }


        public int GetKthLargestUsingMaxHeap(int[] array, int k)
        {
            int N = array.Length;

            for (int i = N / 2; i >= 1; i--)
            {
                max_heapify(array, i, N);
            }


            return -1;
        }

        private int largest = 0;

        private void max_heapify(int[] array, int i, int N)
        {
            int left = 2 * i;
            int right = 2 * i + 1;

            if (left <= N && array[left] > array[i])
                largest = left;
            else
                largest = i;

            if (right <= N && array[right] > array[largest])
                largest = right;

            if (largest != i)
            {
                //swap
                var temp = array[largest];
                array[largest] = array[i];
                array[i] = temp;

                max_heapify(array, largest, N);
            }
        }


    }
}
