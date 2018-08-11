using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.HashSets
{
    public class TopKMostFrequentElements
    {
        /// <summary>
        /// Leetcode #347. Top K Frequent Elements
        /// Given a non-empty array of integers, return the k most frequent elements.
        /// For example, Given[1, 1, 1, 2, 2, 3] and k = 2, return [1,2].
        /// https://leetcode.com/problems/top-k-frequent-elements/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            List<int>[] bucket = new List<int>[nums.Length + 1];
            var frequencyDict = new Dictionary<int, int>();

            //Build out dictionary
            foreach (var item in nums)
            {
                if (frequencyDict.ContainsKey(item))
                {
                    frequencyDict[item]++;
                }
                else
                {
                    frequencyDict.Add(item, 1);
                }
            }

            //Bucket items into array
            foreach (var frequency in frequencyDict)
            {
                if (bucket[frequency.Value] == null)
                {
                    bucket[frequency.Value] = new List<int> { frequency.Key };
                }
                else
                {
                    bucket[frequency.Value].Add(frequency.Key);
                }
            }

            List<int> result = new List<int>(k);

            for (int i = bucket.Length - 1; i > 0; i--)
            {
                if (result.Count >= k)
                {
                    break;
                }

                if (bucket[i] != null)
                {
                    result.AddRange(bucket[i]);
                }
            }


            return result;
        }
    }
}
