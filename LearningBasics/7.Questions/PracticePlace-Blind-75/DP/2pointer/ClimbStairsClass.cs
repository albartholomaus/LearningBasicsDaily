using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP
{
    public class ClimbStairsClass
    {
        int[] cache;

        public ClimbStairsClass()
        {
            ClimbStairsBottomUPOptimized(3);

        }

        public int ClimbStairs(int n)
        {
            cache = new int[n];
            for (int i = 0; i < n; i++)
            {
                cache[1] = -1;
            }
            return DfsTD(n, 0);//<--you only need this for the basic recursion
        }

        private int DfsTD(int target, int currentStep)
        {
            if (currentStep > target) return currentStep == target ? 1 : 0;

            return DfsTD(target, currentStep + 1) + DfsTD(target, currentStep + 2);
        }
        private int DfsBasicRecursion(int target, int currentStep)//this is wrong will fix in the next pass through 
        {
            if (currentStep > target) return currentStep == target ? 1 : 0;
            if (cache[currentStep] != -1) return cache[currentStep];
            return DfsBasicRecursion(target, currentStep + 1) + DfsBasicRecursion(target, currentStep + 2);
        }

        public int ClimbStairsBottomUp(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int[] cache = new int[n + 1];
            cache[1] = 1;
            cache[2] = 2;
            for (int i = 3; i < n; i++)
            {
                cache[i] = cache[i + 1] + cache[1 + 2];
            }
            return cache[n];
        }
        public int ClimbStairsBottomUPOptimized(int n)
        {
            int one = 1, two = 2;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }
            return one;
        }
    }
}
