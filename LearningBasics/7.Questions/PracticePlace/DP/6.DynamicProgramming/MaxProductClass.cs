using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class MaxProductClass
    {
        public MaxProductClass()
        {
            int[] nums = [1, 2, -3, 4];

            MaxProduct(nums);
        }

        public int MaxProduct(int[] nums)
        {
            int result = nums[0];
            int currentMin = 1, currentMax = 1;

            foreach (var num in nums)
            {
                int temp = currentMax * num;
                currentMax = Math.Max(Math.Max(num * currentMax, num * currentMin), num);
                currentMin = Math.Min(Math.Min(temp, num * currentMin), num);
                result = Math.Max(result, currentMax);
            }
            return result;
        }
    }
}
