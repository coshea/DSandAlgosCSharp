using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Trie
{
    public class TrieNode
    {
        public bool HasValue;
        public Dictionary<char, TrieNode> Children;

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            HasValue = false;
        }
    }

    /// <summary>
    /// Leetcode #208. Implement Trie (Prefix Tree)
    /// Implement a trie with insert, search, and startsWith methods.
    /// </summary>
    public class TrieImplementation
    {
        private TrieNode _root;

        /** Initialize your data structure here. */
        public TrieImplementation()
        {
            _root = new TrieNode();
        }

        private TrieNode GetNode(string word, bool create)
        {
            TrieNode node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    if (create)
                    {
                        node.Children.Add(c, new TrieNode());
                    }
                    else
                    {
                        return null;
                    }
                }

                node = node.Children[c];

            }

            return node;
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var newNode = GetNode(word, true);
            newNode.HasValue = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var resultNode = GetNode(word, false);
            if (resultNode == null)
            {
                return false;
            }

            return resultNode.HasValue;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var resultNode = GetNode(prefix, false);
            return resultNode != null;
        }
    }
}
