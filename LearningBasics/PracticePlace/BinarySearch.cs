using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace
{
    public class BinarySearch
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int leftPointer = 0;
            int rightPointer = matrix.Length - 1;


            while (leftPointer <= rightPointer)
            {
                int mid = (leftPointer + rightPointer) / 2;
                if (target < matrix[mid][0])
                {
                    rightPointer = mid - 1;
                }

                else if (target > matrix[mid][matrix.Length])
                {
                    leftPointer = mid + 1;
                }
                else if (target < matrix[mid][matrix.Length] && target > matrix[mid][0])
                {
                    leftPointer = 0;
                    rightPointer = matrix.Length;

                    while (leftPointer < rightPointer)
                    {
                        int currentArrayMid = (leftPointer + rightPointer) / 2;

                        if (target < matrix[mid][currentArrayMid])
                        {
                            rightPointer = currentArrayMid - 1;
                        }
                        else if (target > matrix[mid][currentArrayMid])
                        {
                            leftPointer = currentArrayMid + 1;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static int MinEatingSpeed(int[] piles, int h)
        {
            int leftPointer = 1;
            int RightPointer = piles.Max();
            int results = 0;
            while (leftPointer <= RightPointer)
            {
                int middle = (leftPointer + RightPointer) / 2;

                long totalTimeinHours = 0;
                foreach (var pile in piles)
                {
                    totalTimeinHours += (int)Math.Ceiling((double)pile / middle);
                }

                if (totalTimeinHours <= h)
                {

                    results = middle;
                    //need to increase our rate as we took to long to eat them. 
                    RightPointer = middle - 1;
                }
                else
                {

                    //need to increase the rate as it was 2 small 
                    leftPointer = middle + 1;
                }
            }
            return results;
        }
        public static int FindMin(int[] nums)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;
            int result = nums[0];
            while (leftIndex <= rightIndex)
            {
                if (nums[leftIndex] < nums[rightIndex])
                {
                    result = Math.Min(result, nums[leftIndex]);
                    break;
                }
                int middleIndex = (leftIndex + rightIndex) / 2;
                result = Math.Min(result, nums[middleIndex]);
                if (nums[middleIndex] >= nums[leftIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }
            return result;
        }

    }
}
