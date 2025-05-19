using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP
{
    internal class LongestPalindromeClass
    {
        public LongestPalindromeClass()
        {
            string s = "bb";
            LongestPalindrome(s);

        }

        public string LongestPalindrome(string s)
        {
            int resultLength = 0;
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                int left = i, right = i;

                while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
                {
                    if (right - left + 1 > resultLength)
                    {
                        resultLength = right - left + 1;
                        int arrayIndexRight = right + 1;
                        result = s[left..arrayIndexRight];
                    }
                    left--;
                    right++;
                }
                left = i;
                right = i+1;
                while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
                {
                    if (right - left + 1 > resultLength)
                    {
                        resultLength = right - left + 1;
                        int arrayIndexRight = right + 1;
                        result = s[left..arrayIndexRight];
                    }
                    left--;
                    right++;
                }
            }
            return result;
        }

    }
}
