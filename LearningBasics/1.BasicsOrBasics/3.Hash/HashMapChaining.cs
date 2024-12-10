using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LearningBasics._1.BasicsOrBasics._3.Hash
{
    public class HashMapChaining
    {
        private ChainingNode[] hashMap = new ChainingNode[10];


        public HashMapChaining()
        {
            for (int i = 0; i < hashMap.Length; i++)
            {
                hashMap[i] = new ChainingNode();
            }

            Put(15, 10);
            Put(15, 12);
            Put(15, 11);
            Remove(15,0);
        }

        public void Put(int key, int value)
        {
            ChainingNode current = hashMap[key % hashMap.Length];

            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = new ChainingNode(key, value);
                    return;
                }
                current = current.Next;
            }
        }
        public void Put()
        { 
            
        }
        public void Get(int key)
        {
            ChainingNode current = hashMap[key % hashMap.Length];
            while (current != null)
            {
                if (current.Key == key)
                {
                    Console.WriteLine($"{key}=={current.Value}");
                }
                current = current.Next;
            }
        }
        public void Remove(int key, int value = 0)
        {
            ChainingNode current = hashMap[key % hashMap.Length];
            while (current != null)
            {
                if (current.Next != null && value == 0)
                {
                    current.Next = null;
                    return;
                }
                else if (current.Value == value)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        }
        public void Print()
        {
            for (int i = 0; i < hashMap.Length; i++)
            {
                ChainingNode current = hashMap[i];
                while (current != null)
                {
                    Console.Write($"index={hashMap[i]},key{current.Key}, has Value{current.Value} ");
                    current = current.Next;
                }
                Console.WriteLine("================");
            }
        }
    }
}
public class ChainingNode
{
    public int Value { get; set; }
    public int Key { get; set; }
    public ChainingNode Next { get; set; }

    public ChainingNode(int key = 0, int value = 0, ChainingNode next = null)
    {
        Value = value;
        Key = key;
        Next = next;
    }
}
