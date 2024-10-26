using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics.Hash
{
    internal class CreateHasSet
    {
        Node[] array = new Node[10];
        NodeP[] arrayP = new NodeP[10];

        public CreateHasSet()
        {
            for (int i = 0; i < array.Length; i++)
            {
                arrayP[i] = new NodeP();
            }
        }

        public void Put(int key, int value)
        {
            Node current = array[key % array.Length];

            while (current.next != null)
            {
                if (current.next == null)
                {
                    current.next.value = value;
                    current.next.key = key;
                    return;
                }
                current = current.next;
            }
            current.next = new Node(key, value);
        }
        public void PutP(int key, int value)
        {
            NodeP current = arrayP[key % arrayP.Length];
            while (current.Next != null)
            {
                if (current.Next == null)
                {
                    current.Next.Value = value;
                    current.Next.Value = key;
                    return;
                }
                current = current.Next;
            }
        }
        public int Get(int key)
        {
            Node current = array[key % array.Length];

            while (current.next != null)
            {
                if (key == current.next.key)
                {
                    return current.next.value;
                }
                current = current.next;
            }
            return -1;
        }

        public void Remove(int key)
        {
            Node current = array[key % array.Length];

            while (current.next != null)
            {
                if (key == current.next.key)
                {
                    current.next = null;
                    return;
                }
                current = current.next;
            }

        }
    }
    public class Node
    {
        public int value;
        public int key;
        public Node next;

        public Node(int key = 0, int value = 0, Node next = null)
        {
            this.value = value;
            this.key = key;
            this.next = next;
        }

    }
    public class NodeP
    {
        public int Value { get; set; }
        public int Key { get; set; }
        public NodeP Next { get; set; }

        public NodeP(int key = 0, int value = 0, NodeP next = null)
        {
            Value = value;
            Key = key;
            Next = next;
        }
    }
}

