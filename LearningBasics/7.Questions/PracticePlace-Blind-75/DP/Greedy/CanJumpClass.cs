using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP.Greedy
{
    public class CanJumpClass
    {
        public CanJumpClass()
        {
            int[] nums = { 1, 2, 0, 1, 0};
            CanJump(nums);

        }
        public bool CanJump(int[] nums)
        {
            int goalIndex = nums.Length - 1;

            for (int currentIndex = nums.Length - 2; currentIndex >= 0; currentIndex--)
            {
                if (currentIndex + nums[currentIndex] >= goalIndex)
                {
                    goalIndex = currentIndex;
                }
            }
            return goalIndex == 0;
        }
    }
}
