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
        public int Sum;
        public Dictionary<char, TrieNode> Children;

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            HasValue = false;
            Sum = 0;
        }
    }
}
