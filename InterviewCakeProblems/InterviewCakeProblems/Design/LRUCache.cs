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
                removeNode(n);
                setNewHead(n);

                return n.Value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            // Cache contains key, update value and re-sort
            if (cache.TryGetValue(key, out Node n))
            {
                removeNode(n);

                n.Value = value;

                setNewHead(n);
                return;
            }

            // Add new node
            Node newNode = new Node(key, value);

            // cache is over capacity, replace least used
            if (cache.Count >= _capacity)
            {
                //Remove least used           
                cache.Remove(_tail.Key);
                removeNode(_tail);
            }

            cache.Add(key, newNode);
            // Set new node as head
            setNewHead(newNode);
        }


        private void removeNode(Node n)
        {
            if (n.Prev != null)
            {
                n.Prev.Next = n.Next;
            }
            else
            {
                _head = n.Next;
            }

            if (n.Next != null)
            {
                n.Next.Prev = n.Prev;
            }
            else
            {
                _tail = n.Prev;
            }

        }

        private void setNewHead(Node n)
        {
            n.Next = _head;
            n.Prev = null;

            if (_head != null)
            {
                _head.Prev = n;
            }

            _head = n;

            if (_tail == null)
            {
                _tail = _head;
            }

        }




    }
}
