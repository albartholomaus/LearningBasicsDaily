using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._3.TopAlgorithm
{
    public class SlidingWindowFixed
    {
        int[] nums = [1, 2, 3, 9, 5, 9];

        public SlidingWindowFixed()
        {
            FindDupsBF(nums, 3);
        }

        //Q: Given an array, return true if there are two elements within a window of size k that are equal.
        public bool CloseDupsBruteForce(int[] nums, int subArraySize)
        {
            for (int L = 0; L < nums.Length; L++)
            {
                for (int R = 0; R < Math.Min(nums.Length, L + subArraySize); R++)
                {
                    if (nums[L] == nums[R])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool FindDupsBF(int[] nums, int subArraySize)
        {
            for (int L = 0; L < nums.Length; L++)
            {
                for (int R = 0; R < Math.Min(nums.Length,L+subArraySize); R++)
                {
                    if (nums[L]==nums[R])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool CloseDups(int[] nums, int subArraySize) //might be able to rewrite this to not use pointers
        {
            HashSet<int> window = new();
            int L = 0;
            for (int R = 0; R < nums.Length; R++)
            {
                if (R - L + 1 > subArraySize)
                {
                    window.Remove(nums[L]);
                    L++;
                }
                if (window.Contains(nums[R]))
                {
                    return true;
                }
                window.Add(nums[R]);
            }
            return false;
        }
        public bool CloseDups1(int[] nums, int subArraySize)
        {
            HashSet<int> window = new();
            int L = 0;
            for (int R = 0; R < nums.Length; R++)
            {

                if (R-L+1>subArraySize)
                {
                    window.Remove(nums[L]);
                    L++;
                }
                if (window.Contains(nums[R]))
                {
                    return true;
                }
                window.Add(nums[R]);
            }
            return false;
        }
    }
}
