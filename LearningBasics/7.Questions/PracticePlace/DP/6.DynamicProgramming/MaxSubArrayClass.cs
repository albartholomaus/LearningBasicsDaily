using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class MaxSubArrayClass
    {
      
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0], currentSum = 0;

            foreach (var num in nums)
            {
                if (currentSum < 0) currentSum = 0;
                currentSum += num;
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
      
    }
}
