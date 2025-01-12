using LearningBasics.BasicsOrBasics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicAlgorthims
{
    public class MergeSort
    {
        private int[] aux;

        public MergeSort()
        {
            int[] nums = [6, 2, 4, 3, 1];
            aux = new int[nums.Length];
            MergeSortPriamry(nums, 0, nums.Length - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }

        public void MergeSortPriamry(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;// for obvious reasons the left needs to be greater then the right for this if statement to return, if left Index is greater we have hit the lowest limt of a split 

            int middleIndex = (leftIndex + rightIndex) / 2;
            MergeSortPriamry(array, leftIndex, middleIndex);
            MergeSortPriamry(array, middleIndex + 1, rightIndex);
            MergePriamry(array, leftIndex, middleIndex, rightIndex);


        }
        private void MergePriamry(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            //A temporary array temp is created to hold a copy of the segment of array being merged (from leftIndex to rightIndex).
            //his ensures that the original array can be modified during the merging process without losing access to the original values.
            int[] temp = new int[array.Length];

            for (int k = leftIndex; k <= rightIndex; k++)
            {
                temp[k] = array[k];
            }

            //i points to the current position in the left subarray (temp[leftIndex] to temp[middleIndex]).
            //j points to the current position in the right subarray(temp[middleIndex + 1] to temp[rightIndex]).
            //k is for the index of the "main array" while i is for the first half and j is for the second half 
            int i = leftIndex, j = middleIndex + 1;

            //This loop processes the entire range of leftIndex to rightIndex in the main array.
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                //If all elements of the left subarray have been merged, take the remaining elements from the right subarray (temp[j]).the "left subarray" meaing the MAIN array
                if (i > middleIndex)
                {
                    array[k] = temp[j++];
                }
                //If all elements of the right subarray have been merged, take the remaining elements from the left subarray (temp[i]).the "right subarray" is meaning the temp array
                else if (j > rightIndex)
                {
                    array[k] = temp[i++];
                }
                //Compare the current elements from both subarrays:If the element in the right subarray (temp[j]) is smaller, take it and increment j.
                else if (temp[i] > temp[j])
                {
                    array[k] = temp[j++];
                }
                //Otherwise, take the element from the left subarray (temp[i]) and increment i.
                else
                {
                    array[k] = temp[i++];
                }
            }
        }

        public void MergeSortP(int[] array, int LeftIndex, int rightIndex)
        {
            if (LeftIndex >= rightIndex) return;
            int middleIndex = (LeftIndex + rightIndex) / 2;
            MergeSortP(array, LeftIndex, middleIndex);
            MergeSortP(array, middleIndex + 1, rightIndex);
            MergeP(array, LeftIndex, middleIndex, rightIndex);
        }

        private void MergeP(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int[] temp = new int[array.Length];
            for (int currentIndex = leftIndex; currentIndex < rightIndex; currentIndex++)
            {
                temp[currentIndex] = array[currentIndex];
            }
            int lowerHalfIndex = middleIndex, upperHalfIndex = middleIndex + 1;
            for (int currentIndex = leftIndex; currentIndex < rightIndex; currentIndex++)
            {
                if (lowerHalfIndex > middleIndex)
                {
                    array[currentIndex] = temp[upperHalfIndex++];
                }
                else if (upperHalfIndex > middleIndex)
                {
                    array[currentIndex] = temp[lowerHalfIndex++];
                }
                else if (temp[lowerHalfIndex] > temp[upperHalfIndex])
                {
                    array[currentIndex] = temp[upperHalfIndex++];
                }
                else
                {
                    array[currentIndex] = temp[lowerHalfIndex++];
                }
            }
        }

    }
}
//left == left limit 
//right == right limit 
//if "i" is greater then middleIndex or "j" is greater then right index we are out of bounce of the scope of the current indexes we are sorting
//"i" is the index we are stating with and comparing with "j"
//using AUX as the 