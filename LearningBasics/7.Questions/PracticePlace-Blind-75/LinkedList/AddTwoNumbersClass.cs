using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.LinkedList
{
    public class AddTwoNumbersClass
    {


        public AddTwoNumbersClass()
        {
            ListNode l1 = CreateList();
            ListNode l2 = CreateList(4);
            AddTwoNumbers(l1, l2);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode startNode = new ListNode();
            ListNode current = startNode;

            int carry = 0;
            while (l1 != null || l2!=null|| carry!=0) 
            {
                int v1 = l1 != null ? l1.val:0;
                int v2 = l2 != null ? l2.val:0;

                int val= v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            return startNode.next;
        }


        private ListNode CreateList(int val = 1, int ListLength = 3)
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
