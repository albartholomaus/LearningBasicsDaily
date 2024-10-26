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
            ShortestSubArray2(nums, target);
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
        public int LongestSubArray2(int[] nums)
        {
            int L = 0, length = 0;
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

        public int ShortestSubArray(int[] nums, int target)//target== smallest of the total of the window. 
        {

            int L = 0, total = 0;
            int length = int.MaxValue;
            for (int R = 0; R < nums.Length; R++)
            {
                total += nums[R];

                while (total >= target)
                {
                    length = Math.Min(R - L + 1, length);
                    total -= nums[L];
                    L++;
                }
            }
            if (length == int.MaxValue)
            {
                return 0;
            }
            return length;
        }

        public int ShortestSubArray2(int[] nums, int target)
        {
            int L = 0, total = 0;
            int length = int.MaxValue;
            for (int R = 0; R < nums.Length; R++)
            {
                total += nums[R];
                while (total >= target)
                {
                    total -= nums[L];
                    length = Math.Min(length, R - L + 1);
                    L++;
                }
            }

            if (length==int.MaxValue)
            {
                return int.MinValue;
            }
            return length;
        }
    }
}
