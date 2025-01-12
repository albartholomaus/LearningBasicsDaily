using LearningBasics.BasicsOrBasics.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics.LinkedList
{
    public class SingleLinkedListCreate
    {
        public SingleLinkedListCreate()
        {
            Node firstList = CreateListP();
            Node secondList = CreateList();
            ReverseListP(secondList);
            MergeTwoLists(firstList, secondList);
        }


        public static Node CreateList()
        {
            {
                int info = 10;
                Node start = new Node(info);
                Node tail = new Node(info);

                for (int i = 0; i < 3; i++)
                {
                    if (start.Next == null)
                    {
                        info += 10;
                        start.Next = new Node(info);
                        tail = start.Next;

                    }
                    else
                    {
                        info += 10;
                        tail.Next = new Node(info);
                        tail = tail.Next;

                    }
                }
                return start;

            }
        }
        public Node CreateListP()
        {
            Node head = new();

            Node returnNode = head;
            for (int i = 1; i < 5; i++)
            {
                Node NewNode = new(i);
                head.Next = NewNode;
                head = head.Next;
            }
            return returnNode;
        }

        public Node ReverseList(Node head)
        {
            Node previous = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.Next;//soring the variable 
                current.Next = previous;//this does 2 thing it first cut this link to the head node and making it null, then will link the following nodes as they go.  
                previous = current; //setting the node we just worked on to say this is the previous. 
                current = next;//making the next node the one we need to work on
            }
            head = previous;// we need to return previous here as the last next would be null. 
            return head;
        }
        public Node ReverseListP(Node head)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                Node Next = current.Next;
                current.Next = previous;
                previous = current;
                current = Next;
            }
            return previous;
        }

        public Node MergeTwoLists(Node list1, Node list2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;//temp


            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                {
                    tail.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    tail.Next = list2;
                    list2 = list2.Next;
                }
                tail = tail.Next;
            }
            if (list1 != null)
            {
                tail.Next = list1;
            }
            else if (list2 != null)
            {
                tail.Next = list2;
            }
            return dummy.Next;
        }
        public Node MergeListP(Node list1, Node list2)
        {
            Node Temp = new();
            Node returnNode = Temp;

            while (list1 != null && list2!=null)
            {
                if (list1.Value<list2.Value)
                {
                    Temp = list1;
                    list1 = list1.Next;
                }
                else
                {
                    Temp = list2;
                    list2 = list2.Next;
                }
                Temp = Temp.Next;
            }
            if (list1!=null)
            {
                Temp = list1;
            }
            if (list2 != null)
            {
                Temp = list2;
            }
            return returnNode;
        }
    }
    public class Node
    {
        public int Value { set; get; }
        public Node Next { set; get; }

        public Node(int value = 0, Node next = null)
        {
            Value = value;
            Next = next;

        }
    }


}
