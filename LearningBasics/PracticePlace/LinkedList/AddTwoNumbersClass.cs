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

        private void AddTwoNumbers(ListNode listNode1, ListNode listNode2)
        {

        }


        private ListNode CreateList(int value = 1, int ListLength = 3)
        {
            ListNode head;
            ListNode current = new(value);
            head = current;
            for (int i = 0; i < ListLength - 1; i++)
            {
                current.next = new ListNode(value + 1);
                current = current.next;
                value++;
            }
            return head;
        }

        private class ListNode
        {
            public int value { get; set; }
            public ListNode next { get; set; }
            public ListNode(int Value = 0, ListNode Next = null)
            {
                value = Value;
                next = Next;
            }

        }
    }
}
