using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.LinkedList
{
    public class LinkedListNeedCode
    {

        ListNode head = new ListNode(0);

        public LinkedListNeedCode()
        {
            //head.Next = node2;
            //HasCycle(start);
        }

        public ListNode NewLIst()
        {
            ListNode start = head;
            ListNode node2 = new();
            for (int i = 1; i < 8; i++)
            {
                head.next = new ListNode(i);
                head = head.next;
                if (i == 2)
                {
                    node2 = head;
                }
            }
            return start;
        }



        public bool HasCycle(ListNode head)
        {
            if (head.next == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null)
            {

                slow = slow.next;
                fast = fast.next.next;

                if (slow.Equals(fast))
                {
                    return true;
                }
            }
            return false;
        }

    }

    public class ListNode
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
