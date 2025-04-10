using LearningBasics.BasicsOrBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.LinkedList
{
    public class RandomPointer
    {
        public RandomPointer()
        {
            Dictionary<int, Node> toCopy = new Dictionary<int, Node>();

            Node start = CreateList();
            Node returnWithRandom = start;


            while (start != null)
            {
                if (!toCopy.ContainsKey(start.val)) toCopy[start.val] = start;
                start = start.next;
            }


            start = returnWithRandom;

            while (returnWithRandom != null)
            {
                switch (returnWithRandom.val)
                {
                    case 7:
                        returnWithRandom.random = null;
                        break;
                    case 13:
                        returnWithRandom.random = toCopy[7];
                        break;
                    case 11:
                        returnWithRandom.random = toCopy[10];
                        break;
                    case 10:
                        returnWithRandom.random = toCopy[11];
                        break;
                    case 1:
                        returnWithRandom.random = toCopy[7];
                        break;
                    default:
                        break;
                }
                returnWithRandom = returnWithRandom.next;
            }


            copyRandomList(start);
        }


        public static Node copyRandomList(Node head)
        {
            Dictionary<Node, Node> oldToCopy = new();
            Node current = head;

            while (current != null)
            {
                Node copy = new Node(current.val);
                if (!oldToCopy.ContainsKey(current)) oldToCopy[current] = copy;
                current = current.next;
            }
         
            current = head;
            while (current != null)
            {
                Node copied = oldToCopy[current];
                copied.next=;
                copied.random
                current = current.next;
            }

            return head;
        }

        private Node CreateList(int val = 1, int ListLength = 4)
        {
            int[] value = { 7, 13, 11, 10, 1 };
            Node head;
            Node current = new(val);
            head = current;
            for (int i = 0; i <= 4; i++)
            {
                current.next = new Node(value[i]);
                current = current.next;
                val++;
            }
            return head.next;
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}
