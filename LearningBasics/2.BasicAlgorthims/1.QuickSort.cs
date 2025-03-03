using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicAlgorthims
{
    public class QuickSortClass
    {
        public QuickSortClass()
        {
            Sort();
        }
        public void Sort()
        {
            int[] array = [5, 10, 2, 7, 11, 6, 4];
            QSortMedian(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        private static int[] QuickSorting(int[] array, int start, int end)
        {
            //base case 
            //needs to be less then or equal to one as we dont need to pass just 1 index 
            if (end - start + 1 <= 1)
            {
                return array;
            }
            //setting pivot 
            int pivot = array[end];
            //left tracks the position where the next smaller element (less than pivot) should go.
            int left = start;//represents the position where elements smaller than the pivot are placed during partitioning, this should really be better neamed  

            //the below goes through the partition and sorts the partition . 
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)// here we are making a comparison to the pivot as we are attempting to make every comparisons less then the pivot or more then the pivot. so if the pivot is 5 then 1,2,3,4 need to be lower then 5 and 6,7,8,9 need to be higher then 5. that is the reason why we are not swaping between the pivot and i but using pivot and the left. 
                {
                    //set temp 
                    int temp = array[left];
                    //current to left 
                    array[left] = array[i];
                    //move tempt to current
                    array[i] = temp;
                    //need to up data left 
                    left++;
                    //Increment left to update the position for the next smaller element.
                }
            }
            //move pivot in-between left and right, so the "left" variable is the varibale we are swapting "i" with and as we don't do swaps this is where we move the index to as it is the last place we left off because if we dont swap with it 
            array[end] = array[left];
            array[left] = pivot;
            //recursive calls 
            QuickSorting(array, start, left - 1);// so why is left -1 or left +1 here. BECAUSE we just checked left. 
            QuickSorting(array, left + 1, end);
            return array;
            /*the goal here is to make 2 halves, the first is less then the pivot and the right is larger then the pivot.*/
            /* for the pivot swap the reason it is not in the middle(in my case) is because that is were we put the pivot*/
        }

        public int[] QSortEndStart(int[] array, int start, int end)
        {
            if (end - start + 1 <= 1)
            {
                return array;
            }
            int pivot = array[end];
            int SmallerThenPivotIndex = start;
            for (int currentIndex = start; currentIndex < end; currentIndex++)
            {
                if (array[currentIndex] < pivot)
                {
                    int temp = array[currentIndex];
                    array[currentIndex] = array[SmallerThenPivotIndex];
                    array[SmallerThenPivotIndex] = temp;
                    SmallerThenPivotIndex++;
                }
            }
            array[end] = array[SmallerThenPivotIndex];
            array[SmallerThenPivotIndex] = pivot;
            QSortEndStart(array, start, SmallerThenPivotIndex - 1);
            QSortEndStart(array, SmallerThenPivotIndex + 1, end);
            return array;
        }

        public int[] QSortMedian(int[] array, int start, int end)
        {
            if (end - start + 1 <= 1) return array;

            int left = start;

            int mid = start + (end - start) / 2;
            int pivot = Median(array[start], array[mid], array[end]);

            for (int currentIndex = start; currentIndex <= end; currentIndex++)
            {
                if (array[currentIndex] < pivot)
                {
                    int temp = array[currentIndex];
                    array[currentIndex] = array[left];
                    array[left] = temp;
                    left++;
                }

            }
            array[Array.IndexOf(array, pivot)] = array[left];
            array[left] = pivot;

            QSortMedian(array, start, left - 1);
            QSortMedian(array, left + 1, end);

            return array;
        }
        public int[] QsortP(int[] array, int start, int end)
        {
            if (end - start + 1 <= 1) return array;

            int left = start;
            int mid = (end + start) / 2;
            int piviot = MedianP(array[start], array[mid], array[end]);

            for (int i = start; i <= end; i++)
            {
                int temp = array[i];
                array[i] = array[left];
                array[left] = temp;
                left++;
            }
            array[Array.IndexOf(array, piviot)] = array[left];
            array[left] = piviot;
            QsortP(array, start, left - 1);
            QsortP(array, left + 1, end);
            return array;
        }

        private int Median(int a, int b, int c)
        {
            if ((a > b) == (a < c)) return a;
            if ((b > a) == (b < c)) return b;
            return c;
        }


        private int MedianP(int a, int b, int c)
        {
            if ((a > b) == (a < c)) return a;
            if ((b > a) == (b < c)) return b;
            return c;
        }


    }
}
//int pivotIndex = new Random().Next(start, end + 1);
//int pivot = array[pivotIndex];

//int mid = start + (end - start) / 2;
//int pivot = Median(array[start], array[mid], array[end]);
