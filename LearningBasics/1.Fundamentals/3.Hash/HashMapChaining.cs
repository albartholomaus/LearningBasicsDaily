using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
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
            Remove(15, 12);
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
        public void PutP(int key, int value)
        {
            ChainingNode current = hashMap[key%hashMap.Length];
            while (current!=null)
            {
                if (current.Next== null)
                {
                    current = new ChainingNode(value);
                    return;
                }
                current = current.Next;
            }
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
        public void Get(int key, int value)
        {
            ChainingNode current = hashMap[key % hashMap.Length];
            while (current != null)
            {
                if (current.Value == value)
                {
                    Console.WriteLine("found");
                    return;
                }
                current = current.Next;
            }
        }
        public void GetP(int key, int value)
        {
            ChainingNode current = hashMap[key % hashMap.Length];
            while (current != null)
            {
                if (current.Value == value)
                {
                    Console.WriteLine("Found");
                    return;
                }
                current = current.Next;
            }
        }

        public void Remove(int key, int value = 0)
        {

            ChainingNode? current = hashMap[key % hashMap.Length];
            ChainingNode? previous = null;// need this to store the previous node so it works with the below if statement. 

            while (current != null)
            {
                if (current.Value == value)
                {
                    //if head is null, we would need to do this if we find the value in the head of the linked list 
                    if (previous == null)
                    {
                        hashMap[key % hashMap.Length] = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void RemoveP(int key, int value)
        {
            ChainingNode current = hashMap[key % hashMap.Length];
            ChainingNode prev=null;
            while (current != null)
            {
                
                if (current.Value==value)
                {
                    if (prev==null)
                    {
                        hashMap[key % hashMap.Length] = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;

                    }
                }
                prev = current;
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
