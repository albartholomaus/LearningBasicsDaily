using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP
{
    public class RobClass
    {
        public RobClass()
        {
            int[] nums = [2, 7, 9, 3, 1];
            Console.WriteLine(Rob(nums));
            RobBottom_Up_opped(nums);
        }

        public int Rob(int[] nums) => Dfs(nums, 0);

        //simple recrusion 
        private int Dfs(int[] nums, int houseIndex)
        {
            if (houseIndex >= nums.Length)
            {
                return 0;
            }
            //this says skip current, but this is to progress the algorithm to move along every index 
            int skipCurrent = Dfs(nums, houseIndex + 1);

            //we are taking the current index "houseIndex" THEN we skip a house. the  the adjacent or next house over.  
            int robCurrent = nums[houseIndex] + Dfs(nums, houseIndex + 2);

            //int example = Math.Max(Dfs(nums, houseIndex + 1), nums[houseIndex] + Dfs(nums, houseIndex + 2));
            return Math.Max(skipCurrent, robCurrent);
        }

        private int[] Cache;
        public int RobMemo(int[] nums)
        {
            Cache = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                Cache[i] = -1;
            }
            return DfsMemo(nums, 0);
        }
        private int DfsMemo(int[] nums, int houseIndex)
        {
            if (houseIndex >= nums.Length) return 0;

            if (Cache[houseIndex] != -1)
            {
                return Cache[houseIndex];
            }

            int skipCurrent = DfsMemo(nums, houseIndex + 1);
            int robCurrent = nums[houseIndex] + DfsMemo(nums, houseIndex + 2);
            Cache[houseIndex] = Math.Max(skipCurrent, robCurrent);

            return Cache[houseIndex];

        }

        private int RobBottom_Up(int[] nums)
        {
            if (nums.Length <= 2) return Math.Max(nums[0], nums[1]);

            int[] cache = new int[nums.Length];
            cache[0] = nums[0];
            cache[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                cache[i] = Math.Max(cache[i - 1], nums[i] + cache[i - 2]);
            }
            return cache[nums.Length - 1];
        }


        private int RobBottom_Up_opped(int[] nums)
        {
            int twoHousesAgo = 0, previousBest = 0;

            //can be simplified with a foreach
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i] + twoHousesAgo, previousBest);
                twoHousesAgo = previousBest;
                previousBest = temp;
            }
            return previousBest;
        }

    }
}
