using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class LengthOfLISClass
    {
        public LengthOfLISClass()
        {
            int[] nums = [9, 1, 4, 2, 3, 3, 7];

            LengthOfLIS(nums);
        }
        public int LengthOfLIS(int[] nums)
        {
            int[] cache = new int[nums.Length];

            for (int i = 0; i < cache.Length; i++) cache[i] = 1;


            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        cache[i] = Math.Max(cache[i], cache[j] + 1);
                    }
                }
            }
            return cache.Max();
        }

    }
}
