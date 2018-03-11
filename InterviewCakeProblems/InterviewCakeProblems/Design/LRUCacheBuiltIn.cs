using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Design
{
    public class LRUCacheBuiltIn
    {
        private readonly int _capacity;
        private LinkedList<int> _list = new LinkedList<int>();
        private Dictionary<int, int> _cache = new Dictionary<int, int>();

        public LRUCacheBuiltIn(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.TryGetValue(key, out int value))
            {
                _list.Remove(key);
                _list.AddFirst(key);
                return value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            // Cache contains key, update value and re-sort
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;

                _list.Remove(key);
                _list.AddFirst(key);
                return;
            }

            // Add new key
            // cache is over capacity, replace least used
            if (_cache.Count >= _capacity)
            {
                //Remove least used
                LinkedListNode<int> last = _list.Last;
                _cache.Remove(last.Value);
                _list.RemoveLast();
            }

            _cache.Add(key, value);
            // Set new node as head
            _list.AddFirst(key);
        }
    }
}
