using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._1.BasicsOrBasics.Heap
{
    public class HeapPractice
    {
        List<int> heap = new();
        List<int> buildHeap = [10, 20, 90, 44, 54, 12, 99];

        public HeapPractice()
        {
            Heapify(buildHeap);
        }

        public void Heapify(List<int> array)
        {
            array.Add(array[0]);//to make to math work we don't what ant thing at index 0
            heap = array;//make the heap swap work
            int current = (array.Count - 1) / 2;// the -1 and the /2 is because we can cut the time in half 
            while (current > 0)
            {
                int i = current;////
                HeapSwap(i);
                current--;
            }
        }
        public void HeapifyP(List<int> array)
        {
            array.Add(array[0]);
            int current = (array.Count - 1) / 2;
            while (current > 0)
            {
                HeapSwapP();
                current--;
            }
        }

        public void Push(int value)
        {
            if (heap.Count < 1)
            {
                heap.Add(int.MinValue);
            }
            heap.Add(value);
            int i = heap.Count - 1;
            // Percolate up
            while (i > 1 && heap[i] < heap[i / 2])
            {
                int temp = heap[i];
                heap[i] = heap[i / 2];
                heap[i / 2] = temp;
                i = i / 2;//moving the index where we stated it. 
            }
        }
        public void PushP(int value)
        {
            if (heap.Count < 1)
            {
                heap.Add(int.MinValue);
            }
            heap.Add(value);
            int current = heap.Count - 1;
            while (current > 1 && heap[current] < heap[current / 2])
            {
                int temp = heap[current];
                heap[current] = heap[current / 2];
                heap[current / 2] = temp;
                current = current / 2;
            }
        }

        public int Pop()
        {
            int result;
            if (heap.Count == 1)
            {
                return -1;
            }
            if (heap.Count == 2)
            {
                result = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                return result;
            }
            result = heap[1];//so we can return what we popped 
            heap[1] = heap[heap.Count - 1];//this is moving last to the end 
            heap.RemoveAt(heap.Count - 1);//removing what we just moved 
            HeapSwap();
            return result;
        }
        public int PopP()
        {
            int result;
            if (heap.Count == 1)
            {
                return int.MinValue;
            }
            if (heap.Count == 2)
            {
                result = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                return result;
            }
            result = heap[1];
            heap[1] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            return result;
        }
        public void HeapSwap(int i = 1)
        {
            // percolate down
            while (2 * i < heap.Count)
            {
                if (2 * i + 1 < heap.Count && // out of bounce
                    heap[2 * i + 1] < heap[2 * i] &&//make sure right is not greater then left 
                    heap[i] > heap[2 * i + 1])// and to make sure the current is greater the the right 
                {
                    int temp = heap[i];
                    heap[i] = heap[2 * i + 1];
                    heap[2 * i + 1] = temp;
                    i = 2 * i + 1;

                }
                else if (heap[i] > heap[2 * i])//make sure that the current index is greater the the left as this is a min heap and we want to swap. 
                {
                    int temp = heap[i];
                    heap[i] = heap[2 * i];
                    heap[2 * i] = temp;
                    i = 2 * i;
                }
                else
                {
                    return;
                }

            }
        }
        public void HeapSwapP(int i = 1)
        {
            int left = 2 * i;
            int right = 2 * i + 1;
            int current = i;

            while (left < heap.Count)
            {
                if (current < heap.Count && heap[right] < heap[left] && heap[current] > heap[right])
                {
                    int temp = heap[current];
                    heap[current] = heap[right];
                    heap[right] = temp;
                    current = right;
                }
                else if (heap[i] > heap[left])
                {
                    int temp = heap[current];
                    heap[current] = heap[left];
                    heap[left] = temp;
                    current = left;
                }
                else
                {
                    return;
                }
            }

        }
    }
}

