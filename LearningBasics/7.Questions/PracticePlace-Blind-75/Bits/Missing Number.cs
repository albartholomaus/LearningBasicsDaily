using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Bits
{
    internal class Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int xorr = n;
            for (int i = 0; i < n; i++)
            {
                xorr ^= i ^ nums[i];
            }
            return xorr;
        }
        public int MissingNumberMath(int[] nums)
        {
            int results = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                results += i - nums[i];
              //results = results + i - nums[i];
            }
            return results; 
        }
    }
}
