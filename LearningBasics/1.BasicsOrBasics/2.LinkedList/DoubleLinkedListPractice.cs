using LearningBasics.BasicsOrBasics;
using LearningBasics.BasicsOrBasics.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LearningBasics._1.BasicsOrBasics._2.LinkedList
{
    public class DoubleLinkedListPractice
    {

        public DoubleLinkedListPractice()
        {
            DoubleNode start = CreateDoubleListP();

            Console.WriteLine("FirstList");
            Print(start);

            start = ReverseListP(start);
            Console.WriteLine("");
            Console.WriteLine("reversed");
            Print(start);
        }

        public DoubleNode CreateDoubleLinkedList()
        {
            DoubleNode current = new();
            DoubleNode start = new();
            current = start;
            int i = 1;
            while (i < 5)
            {
                DoubleNode NewNode = new DoubleNode(i);
                current.Next = NewNode;
                NewNode.Previous = current;
                current = current.Next;
                i++;
            }
            return start;
        }

        public DoubleNode CreateDoubleListP()
        {
            DoubleNode start = new();
            DoubleNode tail = new(int.MaxValue);
            DoubleNode returnNode = start;

            for (int i = 1; i != 10; i++)
            {
                DoubleNode newDoubleNode = new(i);
                start.Next = newDoubleNode;
                newDoubleNode.Previous = start;
                newDoubleNode.Next = tail;
                tail.Previous = newDoubleNode;
                start = start.Next;

            }

            return returnNode;
        }

        public DoubleNode ReverseList(DoubleNode current)
        {
            if (current == null)
            {
                return null;
            }
            while (current != null)
            {
                DoubleNode Temp = current.Previous;
                current.Previous = current.Next;
                current.Next = Temp;
                
                if (current.Previous == null)
                {
                    return current;
                }
                current = current.Previous;
            }
            return current;
        }

        public DoubleNode ReverseListP(DoubleNode current)
        {
           
            while (current != null)
            {
              
                DoubleNode temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;
                if (current.Previous == null)
                {
                    return current;
                }
                current = current.Previous;
            }
            return current;
        }

        public void Print(DoubleNode head)
        {
            while (head != null)
            {
                if (head.Value==int.MaxValue || head.Value==0)
                {
                    head = head.Next;
                    continue;
                }
                else
                {
                    Console.Write($"{head.Value} ");
                    
                }
                head = head.Next;
            }
        }
    }


    public class DoubleNode
    {
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public int Value { get; set; }

        public DoubleNode(int value = 0, DoubleNode previous = null, DoubleNode next = null)
        {
            Previous = previous;
            Next = next;
            Value = value;
        }

    }
}
//https://www.geeksforgeeks.org/reverse-a-doubly-linked-list/