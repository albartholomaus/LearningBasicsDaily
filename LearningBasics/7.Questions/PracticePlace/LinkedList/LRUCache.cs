using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.LinkedList
{
    public class LRUCache
    {
        private Dictionary<int, LinkedListNode<(int key, int value)>> cache;
        private LinkedList<(int key, int value)> order;
        private int capacity;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
            this.order = new LinkedList<(int key, int value)>();
            calls();
        }


        public int Get(int key)
        {
            if (!cache.ContainsKey(key)) return -1;
            var node = cache[key];
            order.Remove(node);
            order.AddLast(node);
            return node.Value.value;
        }

        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                var node = cache[key];
                order.Remove(node);
                node.Value = (key, value);
                order.AddLast(node);
                return;
            }
            else if (cache.Count == capacity)
            {
                var lru = order.First.Value;
                order.RemoveFirst();
                cache.Remove(lru.key);
            }
            var newNode = new LinkedListNode<(int key, int value)>((key, value));
            order.AddLast(newNode);
            cache[key] = newNode;
        }


        public void calls()
        {
            Put(1, 1);  
            Put(2, 2);  
            Put(3, 3);  
            Get(1);  Get(2); Get(4);
            Put(4, 4);
            Get(1); Get(2); Get(3); Get(4); Get(2);
            Put(1, 8);
            Put(3, 7);
            Get(1); Get(2);Get(3);Get(4);Get(5); Get(2); Get(3); Get(4);
            Put(1, 9);
            Put(6, 6);
            Get(1); Get(2); Get(3); Get(4); Get(5); Get(6);
        }

    }
}


