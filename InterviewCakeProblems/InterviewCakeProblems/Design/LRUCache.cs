using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Design
{
    class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class LRUCache
    {
        private readonly int _capacity;
        private Node _head;
        private Node _tail;
        private Dictionary<int, Node> cache = new Dictionary<int, Node>();

        public LRUCache(int capacity)
        {
            _capacity = capacity;

        }

        public int Get(int key)
        {
            if (cache.TryGetValue(key, out Node n))
            {
                //removeFromCache(n);
                //setNewHead(n);

                return n.Value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {

        }
    }
}
