using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicAlgorthims
{
    internal class QuickSortingPractice
    {
        public QuickSortingPractice()
        {
            Search();
        }
        public void Search()
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        }



        private int BinarySearchMethod(int[] array, int target)
        {
            int left = 0;
            int right = array.Length;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (target > array[mid])
                {
                    left = mid + 1;
                }
                else if (target < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
      
        private int BinarySearchMethodP(int[] array, int target)
        {
            int leftIndex = 0, rightIndex = array.Length;
            int mid = 0;
            while (leftIndex < rightIndex)
            {
                mid = (leftIndex + rightIndex) / 2;
                if (target < array[mid])
                {
                    rightIndex = mid - 1;
                }
                if (target > array[mid])
                {
                    rightIndex = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }


    }
}

