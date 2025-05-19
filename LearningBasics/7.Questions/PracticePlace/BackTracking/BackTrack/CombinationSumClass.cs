using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.BackTrack
{
    public class CombinationSumClass
    {
        List<List<int>> res;

        public List<List<int>> CombinationSum(int[] nums, int target)
        {
            res = new();
            Array.Sort(nums);//this lets us prune (“break early”) once total + nums[i] > target.
            Dfs(0, new List<int>(), 0, nums, target);
            return res;
        }

        private void Dfs(int index, List<int> current, int total, int[] nums, int target)
        {
            if (total == target)
            {
                res.Add(new List<int>(current));
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
                if (total + nums[i] > target) return;//Prune by sum
                current.Add(nums[i]);
                Dfs(i, current, total + nums[i], nums, target);
                current.RemoveAt(current.Count - 1);//After returning from recursion, remove the last element so we can try the next candidate.
            }
        }
       
    }
}
