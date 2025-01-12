using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._3.TopAlgorithm
{
    public class SlidingWindowVariableSize
    {
        public SlidingWindowVariableSize()
        {
            int[] nums = [4, 2, 2, 4, 4, 4, 4, 3, 3, 3];
            int[] numsTotal = [4, 2, 2, 4, 2, 9, 4, 3, 3, 3];
            int target = 8;
            SortestSubnArray(nums, target);
        }
        public int LongestSubArray(int[] nums)
        {
            int length = 0;
            int L = 0;
            for (int R = 0; R < nums.Length; R++)
            {
                if (nums[L] != nums[R])
                {
                    L = R;
                }
                length = Math.Max(length, R - L + 1);
            }
            return length;
        }
        public int LongestSubArrayP(int[] nums)
        {
            int L = 0;
            int length = 0;
            for (int R = 0; R < nums.Length; R++)
            {
                if (nums[L] == nums[R])
                {
                    L = R;
                }
                length = Math.Max(length, R - L + 1);
            }
            return length;
        }



        //give a target value find the shortest total of elements need to make the target value. 
        public int ShortestTotalArray(int[] nums, int target) 
        {// need three varibles, one of the second pointer. the total and the length, length is set to max int as this is to terminate if we end up going out of bonces or hitting the int limit.
            int L = 0, total = 0;
            int length = int.MaxValue;
            for (int R = 0; R < nums.Length; R++)
            {
                //adding to total of the values for the index of R.
                total += nums[R];

                // If we hit the total or go above it we need to calculate the length, then remove where L is, the move up L
                while (total >= target)
                {
                    length = Math.Min(R - L + 1, length);
                    total -= nums[L];
                    L++;
                }
            }
            // int has a max and to make sure we dont go a above it 
            if (length == int.MaxValue)
            {
                return 0;
            }
            //then return length 
            return length;
        }
        public int SortestSubnArray(int[] nums, int target)
        {
            int L = 0, total = 0, length = int.MaxValue;

            for (int R = 0; R < nums.Length; R ++)
            {
                total += nums[R];

                if (total >= target)
                {
                    total -= nums[L];
                    length = Math.Min(length, R - L + 1);
                    L++;
                }
            }
            if (length==int.MaxValue)
            {
                return 0;
            }
            return length;
        }


    }
}
