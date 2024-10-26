using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
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
            MergeSortP(nums, 0, nums.Length - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static int[] MergeSorting(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                MergeSorting(array, leftIndex, middleIndex);
                MergeSorting(array, middleIndex + 1, rightIndex);
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
            return array;
        }
        private static void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            //find the length of the 2 sub arrays
            int leftLength = middleIndex - leftIndex + 1;
            int rightLength = rightIndex - middleIndex;

            var tempLeft = new int[leftLength];
            var tempRight = new int[rightLength];
            //copy the sorted left and right half's to temp array
            for (int a = 0; a < leftLength; a++)
            {
                tempLeft[a] = array[leftIndex + a];
            }
            for (int b = 0; b < rightLength; b++)
            {
                tempRight[b] = array[middleIndex + 1 + b];
            }
            int i = 0;
            int j = 0;
            int k = 1;
            //merge the 2 sorted halfs into the original array 
            while (i < leftIndex && j < rightIndex)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    array[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    array[k] = tempRight[j];
                    j++;
                }
                k++;
            }
            // to copy over the rest if needed 
            while (i < leftLength)
            {
                array[k] = tempLeft[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                array[k] = tempLeft[j];
                i++;
                k++;
            }
        }

        public void MergeSorting1(int[] array, int leftIndex, int rightIndex)
        {
            //for base case:
            // end -start +1 <=1 would also work here 
            if (leftIndex >= rightIndex) return;

            int middleIndex = (leftIndex + rightIndex) / 2;
            MergeSorting1(array, leftIndex, middleIndex);
            MergeSorting1(array, middleIndex + 1, rightIndex);
            Merge1(array, leftIndex, middleIndex, rightIndex);

        }
        public void Merge1(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            //copy to temp the indexes we are using;

            for (int k = leftIndex; k <= rightIndex; k++)
            {
                aux[k] = array[k];
            }

            //create pointers middle is +1;
            int i = leftIndex, j = middleIndex + 1;

            //loop through the indexes 
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                //move left side over 
                if (i > middleIndex)
                {
                    array[k] = aux[j++];

                }
                //move right side over 
                else if (j > rightIndex)
                {
                    array[k] = aux[i++];
                }
                //check for which on is greater them move it to array 
                else if (aux[i] > aux[j])
                {
                    array[k] = aux[j++];
                }
                else
                {
                    array[k] = aux[i++];
                }
            }
        }
        public void MergeSorting2(int[] array, int leftIndex, int rightIndex)
        {

            //we have a global variable 

            //for base case:
            // end -start +1 <=1 would also work here 


            // set middle 
            //recursive 

            //merge

        }

        public void Merge2(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            //copy to temp the indexes we are using;

            //create pointers middle is +1;


            //loop through the indexes 

            //move left side over k<-J

            //move right side over k<-I

            //check for which on is greater them move it to array i-J

            //I don't know edge case maybe 


        }
        public void MergeSorting3(int[] array, int leftIndex, int rightIndex)
        {
            //we have a global variable 
            //for base case:
            if (leftIndex >= rightIndex) return;
            int middleIndex = (leftIndex + rightIndex) / 2;
            MergeSorting3(array, leftIndex, middleIndex);
            MergeSorting3(array, middleIndex + 1, rightIndex);
            Merge3(array, leftIndex, middleIndex, rightIndex);
        }
        public void Merge3(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                aux[k] = array[k];
            }

            int i = leftIndex, j = middleIndex + 1;

            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (i > middleIndex)
                {
                    array[k] = aux[j++];
                }
                else if (j > rightIndex)
                {
                    array[k] = aux[i++];
                }
                else if (aux[i] > aux[j])
                {
                    array[k] = aux[j++];
                }
                else
                {
                    array[k] = aux[i++];
                }
            }
        }

        public void MergeSortP(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }
            int middleIndex = (leftIndex + rightIndex) / 2;
            MergeSortP(array, leftIndex, middleIndex);
            MergeSortP(array, middleIndex + 1, rightIndex);
            MergeP(array, leftIndex, middleIndex, rightIndex);
        }
        public void MergeP(int[] array, int leftIndex, int middleIndex, int RightIndex)
        {
              int[] aux=new int[RightIndex+1];


            for (int K = leftIndex; K <= RightIndex; K++)
            {
                aux[K] = array[K];
            }
            int leftPointer = leftIndex, MiddlePointer = middleIndex + 1;
            for (int k = leftIndex; k <= RightIndex; k++)
            {
                if (leftPointer > middleIndex)
                {
                    array[k] = aux[MiddlePointer++];
                }
                else if (MiddlePointer > RightIndex)
                {
                    array[k] = aux[leftPointer++];
                }
                else if (aux[leftPointer] > aux[MiddlePointer])
                {
                    array[k] = array[MiddlePointer++];
                }
                else
                {
                    array[k] = aux[leftPointer++];
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