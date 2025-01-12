using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LearningBasics._1.BasicsOrBasics.Heap
{
    public class HeapPractice
    {
        /*
         * i/2 = parent
         * 2*i= left 
         * 2*i+1 = right 
         * A heap is not a search tree, to satisfy the order property, for a min heap, we need to have everything that is smaller at the top, can have dups 
         * structure property, can't have gaps up last child "row" can. 
         */
        private List<int> heap = new();
        private List<int> buildHeap = [10, 20, 90, 44, 54, 12, 99];

        public HeapPractice()
        {
            HeapifyP(buildHeap);
            PushP(35);

        }

        public void Heapify(List<int> array)
        {
            array.Add(array[0]);//to make to math work we don't what ant thing at index 0, what we are doing here is taking from the "Front" and adding to the back 
            heap = array;//make the heap swap work, we have heap as global scoped item and we are making the array the heap. we could make some oother changes to not use this here but it a link of code vs a ppossilbe if statement.
            int current = (array.Count - 1) / 2;// the -1 is for the end and the /2 is because we can cut the time in half as we dont need to look at the children 
            while (current > 0)
            {
                int i = current; //passing the current index to the swap method , we dont need this, its extra was likely put here to make learning easier.  
                HeapSwap(i);//passing i here as this is the index where we are starting. 
                current--;
            }
        }
        public void HeapifyP(List<int> array)
        {
            array.Add(int.MinValue);
            heap = array;
            int current = (heap.Count - 1) / 2;
            while (current > 0)
            {
                heapSwapP(current);
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
            int i = heap.Count - 1;// naming is bad here should be currentIndex, we need to set this varaiable as 
            // Percolate up
            while (i > 1 && heap[i] < heap[i / 2])// this says 2 things, First, we need to make sure that the current index is not going outside the bounds of the array. Second, making sure we 
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
                current = SwapP(current, current / 2);
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
            HeapSwap();//not passing any value here as it is going to pop the top
            return result;
        }
        public int PopP()
        {
            int result = 0;
            if (heap.Count < 1)
            {
                return result - 1;
            }
            if (heap.Count == 2)
            {
                result = heap[1];
                heap.RemoveAt(1);
                return result;
            }
            result = heap[1];
            heap[1] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            heapSwapP();
            return result;

        }


        public void HeapSwap(int i = 1)
        {
            // percolate down
            while (2 * i < heap.Count)//do we have a left child
            {
                if (2 * i + 1 < heap.Count && // out of bounce aka a right child 
                    heap[2 * i + 1] < heap[2 * i] &&//confirming the right is less then the left 
                    heap[i] > heap[2 * i + 1])// and to make sure the current is greater the the right // becuase we are going down 
                {
                    int temp = heap[i];
                    heap[i] = heap[2 * i + 1];
                    heap[2 * i + 1] = temp;
                    i = 2 * i + 1;//this set the next index to check is the same value we just looked at to see if the subsequent children need to be swapted. 

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
        private void heapSwapP(int current = 1)
        {
            while (2 * current < heap.Count)
            {
                if (2 * current + 1 < heap.Count && heap[2 * current + 1] < heap[2 * current] && heap[current] > heap[2 * current + 1])
                {
                    current = SwapP(current, 2 * current + 1);
                }
                else if (heap[current] > heap[2 * current])
                {
                    current = SwapP(current, 2 * current);
                }
                else
                {
                    return;
                }
            }
        }


        private void Swap(int index, int MoveToIndex)
        {
            int temp = heap[index];
            heap[index] = heap[MoveToIndex];
            heap[MoveToIndex] = temp;
            index = MoveToIndex;
        }
        private int SwapP(int current, int MovedIndex)
        {
            int temp = heap[current];
            heap[current] = heap[MovedIndex];
            heap[MovedIndex] = temp;
            return current = MovedIndex;
        }
    }
}

