using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
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
            CloseDups(nums, 3);
        }

        //Q: Given an array, return true if there are two elements within a window of size k that are equal.
        public bool DupsBF(int[] nums, int subArraySize)
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

        public bool DupsP(int[] nums, int SubArraySize)
        {
            for (int L = 0; L < nums.Length; L++)
            {
                for (int R = 0; R < Math.Min(nums.Length, L + SubArraySize); R++)
                {
                    if (nums[L] == nums[R])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool CloseDups(int[] nums, int subArraySize) //might be able to rewrite this to not use pointers
        {
            HashSet<int> window = new();//need a hashSet to store what we looked at. 
            int L = 0;//lower pointer
            for (int R = 0; R < nums.Length; R++)//to move along R as we add in number to the value. 
            {
                if (R - L + 1 > subArraySize)//for what ever reason I can never remember this. wat we are saying here is the if we go above the window size in this case it is subarraysize we remove the lower pointer. 
                {
                    window.Remove(nums[L]);// then remove L has it was R at on point and move up L 
                    L++;
                }
                if (window.Contains(nums[R]))//If we found what we are looking for then we are done. 
                {
                    return true;
                }
                window.Add(nums[R]);//adding in R to the value 
            }
            return false;
        }

        public bool DupsHashP(int[] nums, int SubArraySize)
        {
            HashSet<int> window = new();
            int L = 0;
            for (int R = 0; R < nums.Length; R++)
            {
                if (R - L + 1 > SubArraySize)
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
