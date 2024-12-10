using LearningBasics.BasicsOrBasics.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Node start = new();
            Node retunNode = start;
            Node tail = new();

            for (int i = 10; i < 100; i += 10)
            {
                Node newNode = new(i);
                start.Next = newNode;
                newNode.Next = tail;
                start = start.Next;
            }
            return retunNode.Next;
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
            head = previous;
            return head;
        }
        public Node ReverseListP(Node head)
        {
            Node curr = head;
            Node next = null;
            Node prev = null;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
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
        public Node MergeTwoListsP(Node list1, Node list2)
        {
            Node tail=new();
            Node dummy=tail;

            while (list1 != null && list2 != null)
            {
                if (list1.Value > list2.Value)
                {
                    tail = list1;
                    list1 = list1.Next;
                }
                else
                {
                    tail = list2;
                    list1 = list2.Next;

                }
                tail = tail.Next;
            }
            if (list1 == null)
            {
                tail.Next = list2;
            }
            if (list2 == null)
            {
                tail.Next = list1;
            }
            return dummy;
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

    public class Node2
    {
        public int Value { set; get; }
        public Node Next { set; get; }

        public Node2(int value = 0, Node next = null)
        {
            Value = value;
            Next = Next;
        }
    }
}
