using LearningBasics.Patterns.Creational.Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.LinkedList
{
    public class ReOrder
    {

        public ReOrder()
        {
            LinkedListNeedCode head = new ();
            ListNode mehtodHead= head.NewLIst();
            ReorderList1(mehtodHead);
        }
        public void ReorderList(ListNode head)
        {
            //This loop finds the midpoint. When it finishes, slow will be at the middle.
            ListNode slow = head; 
            ListNode fast = head.next;
            while (fast!= null && fast.next !=null)
            {
                //finds mid
                slow = slow.next; 
                //finds end
                fast = fast.next.next; 
            }
            //start of the second half of the list. 
            ListNode second = slow.next;
            /*
             slow.next = null;
            ➤ This cuts the linked list in half by ending the first half at slow.
            ListNode previous = null;
            ➤ This initializes previous to null, which will be used in the reversal step.
             */
            ListNode previous = slow.next=null;

            //Reverse the second half
            while (second !=null)
            {
                //previous will point to the new head of the reversed second half.
                ListNode temp = second.next;
                second.next = previous;
                previous = second;
                second = temp;
            }

            //merge the 2 lists 
            ListNode first = head;
            second = previous;
            while (second != null)
            {
                ListNode tmp1 = first.next;
                ListNode tmp2 = second.next;
                first.next = second;
                second.next = tmp1;
                //shifting pointers 
                first = tmp1;
                second = tmp2;
            }
        }
        public void ReorderList1(ListNode head)
        {
            //This loop finds the midpoint. When it finishes, slow will be at the middle.
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null)
            {
                //finds mid
                slow = slow.next;
                //finds end
                fast = fast.next.next;
            }
            //start of the second half of the list. 
            ListNode second = slow.next;
            ListNode previous = slow.next = null;

            while (second != null)
            {
                //previous will point to the new head of the reversed second half.
                ListNode temp = second.next;
                second.next = previous;
                previous = second;
                second = temp;
            }

            //merge the 2 lists 
            ListNode first = head;
            second = previous;
            while (second != null)
            {
                ListNode tmp1 = first.next;
                ListNode tmp2 = second.next;
                first.next = second;
                second.next = tmp1;
                //shifting pointers 
                first = tmp1;
                second = tmp2;
            }
        }
    }
}
