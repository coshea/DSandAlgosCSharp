using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Trie
{
    /// <summary>
    /// Question #11
    /// Keep track of urls by using a Trie
    /// </summary>
    public class MillionGazillion
    {
        private const char EndOfWordMarker = '\0';

        private TrieNode _rootNode = new TrieNode();

        public bool CheckPresentAndAdd(string word)
        {
            var currentNode = _rootNode;
            bool isNewWord = false;

            // Work downwards through the trie, adding nodes
            // as needed, and keeping track of whether we add
            // any nodes.
            foreach (var character in word)
            {
                if (!currentNode.HasChildNode(character))
                {
                    isNewWord = true;
                    currentNode.MakeChildNode(character);
                }

                currentNode = currentNode.GetChildNode(character);
            }

            // Explicitly mark the end of a word.
            // Otherwise, we might say a word is
            // present if it is a prefix of a different,
            // longer word that was added earlier.
            if (!currentNode.HasChildNode(EndOfWordMarker))
            {
                isNewWord = true;
                currentNode.MakeChildNode(EndOfWordMarker);
            }

            return isNewWord;
        }
    }

    public class TrieNode
    {
        private Dictionary<char, TrieNode> _nodeChildren = new Dictionary<char, TrieNode>();

        public bool HasChildNode(char character)
        {
            return _nodeChildren.ContainsKey(character);
        }

        public void MakeChildNode(char character)
        {
            _nodeChildren[character] = new TrieNode();
        }

        public TrieNode GetChildNode(char character)
        {
            return _nodeChildren[character];
        }
    }

}
