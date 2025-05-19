using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP
{
    internal class Rob2
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            return Math.Max(FindMax(nums[1..]), FindMax(nums[..^1]));
        }
        private int FindMax(int[] nums )
        {
            int twoHousesAgo = 0, previousBest = 0;

            foreach (var num in nums)
            {
                int temp = Math.Max(num + twoHousesAgo, previousBest);
                twoHousesAgo = previousBest;
                previousBest = temp;
            }
            return previousBest;
        }
    }
}
