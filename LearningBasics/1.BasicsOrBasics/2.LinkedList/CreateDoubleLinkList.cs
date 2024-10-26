using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics.LinkedList
{
    internal class CreateDoubleLinkList
    {
        //set up for a dummy nodes
        DoubleNode left = new DoubleNode(0);
        DoubleNode right = new DoubleNode(0);

        public CreateDoubleLinkList()
        {
            left.next = right;
            right.prev = left;
        }

        public int Get(int index)
        {
            DoubleNode current = left.next;
            while (current != null && index > 0)
            {
                current = current.next;
                index--;
            }
            if (current != null && current != right && index == 0)
            {
                return current.value;
            }
            return -1;
        }

        public void AddAtHead(int val)
        {
            DoubleNode node = new DoubleNode(val);
            DoubleNode previous = left;
            DoubleNode next = left.next;
            //working with the previous node
            previous.next = node;
            node.prev = previous;
            //working with the outside node.
            next.prev = node;
            node.next = next;
        }

        public void AddAtTail(int val)
        {
            DoubleNode node = new DoubleNode(val);
            DoubleNode previous = right.prev;
            DoubleNode next = right;
            //working with the previous node
            previous.next = node;
            node.prev = previous;
            //working with the outside node. 
            next.prev = node;
            node.next = next;
        }

        public void AddAtIndex(int index, int val)
        {
            DoubleNode current = left.next;
            while (current != null && index > 0)
            {
                current = current.next;
                index--;
            }
            if (current != null && index == 0)
            {
                DoubleNode node = new DoubleNode(val);
                DoubleNode previous = current.prev;
                DoubleNode next = current;
                //working with the previous node
                previous.next = node;
                node.prev = previous;
                //working with the outside node. 
                next.prev = node;
                node.next = next;
            }
        }

        public void DeleteAtIndex(int index)
        {
            DoubleNode current = left;
            while (current != null && index > 0)
            {
                current = current.next;
                index--;
            }
            if (current != null && current != right && index == 0)
            {
                DoubleNode previous = current.prev;
                DoubleNode next = current.next;
                //working with the previous node
                previous.next = next;
                //working with the next node 
                next.prev = previous;
            }
        }


    }

    public class DoubleNode
    {
        public DoubleNode prev;
        public int value;
        public DoubleNode next;

        public DoubleNode(int info)
        {
            prev = prev;
            value = info;
            next = next;

        }

    }
}
//LinkedList linkedlist = new LinkedList();
//linkedlist.MakeLinkLists();"
//DesignLinkedList designLinkedList = new DesignLinkedList();
//designLinkedList.AddAtHead(1);
//designLinkedList.AddAtTail(3);
//designLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
//designLinkedList.Get(1);              // return 2
//designLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
//designLinkedList.Get(1);              // return 3
