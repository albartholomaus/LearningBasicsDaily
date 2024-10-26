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
        DoubleNode start = new DoubleNode();
        DoubleNode tail = new DoubleNode();
        public DoubleLinkedListPractice()
        {
            start.Next = tail.Previous;
            tail.Previous = start.Next;
            Console.WriteLine("FirstList");
            CreateDoubleLinkedList();
            Print(start);
            start = ReverseList2(start);
            Console.WriteLine("");
            Console.WriteLine("FirstList");
            Print(start);
        }


        public void CreateDoubleLinkedList()
        {
            DoubleNode current;
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
        }

        public DoubleNode ReverseList(DoubleNode current)
        {
            if (current == null)
            {
                return null;
            }
            DoubleNode temp = current.Previous;
            current.Previous = current.Next;
            current.Next = temp;
            if (current.Previous == null)
            {
                return current;
            }
            return ReverseList(current.Previous);
        }
        public DoubleNode ReverseList2(DoubleNode current)
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
        public void Print(DoubleNode head)
        {
            while (head != null)
            {
                Console.Write($"{head.Value}");
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