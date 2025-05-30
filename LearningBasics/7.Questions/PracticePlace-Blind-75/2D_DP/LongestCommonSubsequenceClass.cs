using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace._2D_DP
{
    public class LongestCommonSubsequenceClass
    {
        public LongestCommonSubsequenceClass()
        {
            string one = "cat";
            string two = "crabt";

            LongestCommonSubsequence(one, two);
        }

        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] cache = new int[text1.Length + 1, text2.Length + 1];
            for (int i = text1.Length - 1; i >= 0; i--)
            {
                for (int j = text2.Length - 1; j >= 0; j--)
                {
                    if (text1[i] == text2[j]) cache[i, j] = 1 + cache[i + 1, j + 1];
                    else cache[i, j] = Math.Max(cache[i, j + 1], cache[i + 1, j]);
                }
            }
            return cache[0, 0];
        }
    }
}
