using LearningBasics.BasicsOrBasics;
using LearningBasics.BasicsOrBasics.Hash;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace LearningBasics._1.BasicsOrBasics._2.LinkedList
{
    public class DoubleLinkedListPractice
    {

        public DoubleLinkedListPractice()
        {
            DoubleNode start = CreateDoubleLinkedListP();

            Console.WriteLine("First Created");
            Print(start);

            start = ReverseListP(start);
            Console.WriteLine("");
            Console.WriteLine("reversed");
            Print(start);
        }

        public DoubleNode CreateDoubleLinkedListWithAHeadAndTail()
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
       
        public DoubleNode CreateDoubleLinkedList()
        {
            DoubleNode head =new(0);
            DoubleNode tail = new(int.MaxValue);
            DoubleNode returnNode = head;

            for (int i = 1; i < 5; i++)
            {
                DoubleNode newNode = new(i);
                head.Next = newNode;
                newNode.Previous = head;
                tail.Previous = newNode;
                newNode.Next = tail;
                head = head.Next;
            }
            return returnNode;
        }
        public DoubleNode CreateDoubleLinkedListP()
        {
            DoubleNode temp = new();
            DoubleNode ReturnNode = temp;
            for (int i = 1; i < 6; i++)
            {
                DoubleNode newNode = new(i);
                temp.Next = newNode;
                newNode.Previous = temp;
                temp = temp.Next;
            }
            return ReturnNode;
        }

        public DoubleNode ReverseList(DoubleNode current)
        {
            //checks if the Node we are getting is even there. if not stop. 
            if (current == null)
            {
                return null;
            }
            while (current != null)
            {
                //here we are swaping points of the previous and the next. 
                DoubleNode Temp = current.Previous;//stores node 
                current.Previous = current.Next;//moving next to previous, this also means that the Previous is NOT null preventing to terminating condition. 
                current.Next = Temp;//moving the stored pointer to the next position 

                //this is a terminatior, if current. Previous is ever null, we stop and return previous. 
                if (current.Previous == null)
                {
                    return current;
                }
                //because previous was tje next in line for what we need to move around we need to move current.Previous in to current to begain to work untill it is null./ 
                current = current.Previous;
            }
            //this should never be called if it does then something is wrong. 
            return null;
        }

        public DoubleNode ReverseListP(DoubleNode current)
        {
            if (current ==null)
            {
                return null;
            }
            while (current!=null)
            {
                DoubleNode temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;

                if (current.Previous==null)
                {
                    return current;
                }
            }
            return null;
        }

        public void Print(DoubleNode head)
        {
            while (head != null)
            {
                if (head.Value == int.MaxValue || head.Value == 0)
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