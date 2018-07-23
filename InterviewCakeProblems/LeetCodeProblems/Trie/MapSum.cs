using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trie
{
    /// <summary>
    /// <para>
    /// Leetcode #677. Map Sum Pairs
    /// Implement a MapSum class with insert, and sum methods.
    /// </para>
    /// <para>
    /// For the method insert, you'll be given a pair of (string, integer). 
    /// The string represents the key and the integer represents the value. 
    /// If the key already existed, then the original key-value pair will be overridden to the new one.
    /// </para>
    /// <para>
    /// For the method sum, you'll be given a string representing the prefix, 
    /// and you need to return the sum of all the pairs' value whose key starts with the prefix.
    /// </para>
    /// <para>
    /// Example 1:
    ///     Input: insert("apple", 3), Output: Null
    ///     Input: sum("ap"), Output: 3
    ///     Input: insert("app", 2), Output: Null
    ///     Input: sum("ap"), Output: 5
    /// </para>
    /// </summary>
    public class MapSum
    {
        private TrieNode _root = new TrieNode();

        /** Initialize your data structure here. */
        public MapSum()
        {

        }

        private TrieNode GetNode(string key, int val, bool create)
        {
            TrieNode node = _root;

            foreach (char c in key)
            {
                if (!node.Children.ContainsKey(c))
                {
                    if (create)
                    {
                        node.Children.Add(c, new TrieNode() /*{ Sum = val }*/);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    //node.Sum += val;
                }

                node = node.Children[c];
                node.Sum += val;
            }

            return node;
        }

        public void Insert(string key, int val)
        {
            var resultNode = GetNode(key, val, true);
            resultNode.HasValue = true;
        }

        public int Sum(string prefix)
        {
            var resultNode = GetNode(prefix, 0, false);
            if (resultNode == null)
            {
                return 0;
            }
            return resultNode.Sum;
        }
    }
}
