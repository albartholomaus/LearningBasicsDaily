using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.LinkedList
{
    public class RemoveNth
    {
        public RemoveNth()
        {
            ListNode start = CreateList();
            RemoveNthFromEnd(start, 2);

        }


        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int rightPointer = 0;
            ListNode current = head;

            while (current != null) { 
                rightPointer++;
                current = current.next;
            }

            int removeIndex = rightPointer - n;
            if (removeIndex==0)
            {
                return head.next;
            }

            current = head;

            for (int i = 0; i < removeIndex; i++)
            {
                if (i+1==removeIndex)
                {
                    current.next=current.next.next;
                    break;
                }
                current = current.next;
            }
            return head;
        }

        private ListNode CreateList(int val = 1, int ListLength = 4)
        {
            ListNode head;
            ListNode current = new(val);
            head = current;
            for (int i = 0; i < ListLength - 1; i++)
            {
                current.next = new ListNode(val + 1);
                current = current.next;
                val++;
            }
            return head;
        }

        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }
            public ListNode(int Value = 0, ListNode Next = null)
            {
                val = Value;
                next = Next;
            }

        }
    }


}
