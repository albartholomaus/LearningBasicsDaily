using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
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
            int[] array = [5, 10, 2, 7, 11, 6, 4, 8, 9, 1, 5];
            //QuickSortP(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        private static int[] QuickSorting(int[] array, int start, int end)
        {
            //terminator
            if (end - start + 1 <= 1)
            {
                return array;
            }
            //need to set pivot, pivot == the value not the index
            int pivot = array[end];
            //need to set start 
            int left = start;//pointer for the left side 
            //loop through with a temp variable to make sure 
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    //set temp 
                    int temp = array[left];
                    //current to left 
                    array[left] = array[i];
                    //move tempt to current
                    array[i] = temp;
                    //need to up data left 
                    left++;
                }
            }
            //move pivot in-between left and right 
            array[end] = array[left];
            array[left] = pivot;
            //recursive calls 
            QuickSorting(array, start, left - 1);
            QuickSorting(array, left + 1, end);
            return array;
            /*the goal here is to make 2 halves, the first is less then the pivot and the right is larger then the pivot.*/
            /* for the pivot swap the reason it is not in the middle(in my case) is because that is were we put the pivot*/
        }

        public static int[] QuickSortingTemplate(int[] array, int start, int end)
        {
            //terminator

            //need to set pivot 


            //need to set start 

            //loop through with a temp variable to make sure 

            //set temp 

            //current to left 

            //move tempt to current

            //need to up data left 

            //move pivot in-between left side being the  and right 

            //recursive calls 
            return array;
        }


        public int[] QSortP(int[] array, int start, int end)
        {
            if (end - start + 1 <= 1)
            {
                return array;
            }
            int pivot = array[end];
            int left = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[left];
                    array[left] = array[i];
                    left++;
                }
            }
            array[end] = array[left];
            array[left] = pivot;
            QSortP(array, start, left - 1);
            QSortP(array, left + 1, end);
            return array;
        }


    }
}
