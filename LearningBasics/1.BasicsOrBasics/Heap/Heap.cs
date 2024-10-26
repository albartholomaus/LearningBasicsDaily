using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics
{
    public class Heap
    {
        // the math for the child and parent
        // leftChild = 2 * i
        //rightChild = 2 * i + 1
        //parent= i / 2

        List<int> heap = new();

        List<int> array = [60, 50, 80, 40, 30, 10, 70, 20, 90];//why list, so we don't run out of space. also this is for the build heap 


        public Heap()
        {
            MaxPush(10);
            MaxPush(60);
            MaxPush(80);
            MaxPush(20);
            MaxPush(900);
        }
        public void Push(int val)
        {
            
            heap.Add(val);
            int i = heap.Count - 1;//starting from the back 
            while (i > 1 && heap[i] < heap[i / 2])
            {
                int temp = heap[i];
                heap[i] = heap[i / 2];
                heap[i / 2] = temp;
                i = i / 2;
            }
        }
        public void MinPush(int val)
        {
            if (heap.Count < 1)
            {
                heap.Add(int.MinValue);
            }
            heap.Add(val);//adding to the end 
            int i = heap.Count - 1;//this is the index were we just put the value about 

            while (i > 1
            && heap[i] < heap[i / 2])
            {
                int temp = heap[i];
                heap[i] = heap[i / 2];
                heap[i / 2] = temp;
                i = i / 2;//this is for the loop to know where we are next 
            }
        }
        public void MaxPush(int val)
        {
            if (heap.Count == 0)
            {
                heap.Add(int.MaxValue);
            }
            heap.Add(val);
            int i = heap.Count - 1;
            while (i > 1 && heap[i] > heap[i / 2])
            {
                int temp = heap[i];
                heap[i] = heap[i / 2];
                heap[i / 2] = temp;
                i = i / 2;
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
                heap.Remove(heap.Count - 1);
                return result;
            }
            result = heap[1];
            heap[1] = heap[heap.Count - 1];
            heap.Remove(heap.Count - 1);
           // int i = 1;//setting i to index 1 I don't think I need this 
            HeapSwap();
            return result;
        }

        public int PopP()
        {
            int result;
            if (heap.Count == 1)
            {
                return -1;
            }
            if (heap.Count == 2)
            {
                result = heap[heap.Count - 1];
                heap.Remove(heap.Count - 1);
                return result;
            }
            result = heap[1];//so we can return what we popped 
            heap[1] = heap[heap.Count - 1];//this is moving last to the end 
            heap.Remove(heap.Count - 1);//removing what we just moved 
            HeapSwap();
            return result;
        }
        public void HeapSwap(int i=1)
        {
            //will run only it it has a left child
            while (2 * i < heap.Count)
            {
                if (2 * i + 1 < heap.Count // checks if we also have a right child
                    && heap[2 * i + 1] < heap[2 * i] // AND if the right child is smaller then the left child
                    && heap[i] > heap[2 * i + 1]) // AND the current node is greater the the right child <--because min heap
                {
                    //swap right
                    int temp = heap[i];
                    heap[i] = heap[2 * i + 1];
                    heap[2 * i + 1] = temp;
                    i = 2 * i + 1;
                }
                //is current node greater then the left 
                else if (heap[i] > heap[2 * i])
                {
                    //swap left
                    int temp = heap[i];
                    heap[i] = heap[2 * i];
                    heap[2 * i] = temp;
                    i = 2 * i;
                }
                //means that none of the able needs to be done and it meets all the needs. 
                else
                {
                    break;
                }
            }
        }

     

      

        public void Heapify(List<int> arr)// AKA build heap
        {//O(N)
            //move to end
            arr.Add(arr[1]); 
            heap = arr;
            int cur = (heap.Count - 1) / 2;//here is where we are starting, why here ? it is to optimize 
            while (cur > 0)
            {
                int i = cur;
                HeapSwap(i);
                cur--;
            }
        }
    }
}
