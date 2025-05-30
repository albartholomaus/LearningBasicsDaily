using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP
{
    public class CountSubstringsClass
    {
        public CountSubstringsClass()
        {
            string s = "aaa";
            CountSubstrings(s);
        }
        public int CountSubstrings(string s)
        {
            int SubStringCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int left = i, right = i;

                while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
                {
                    SubStringCount++;
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;

                while (left >= 0 && right <= s.Length - 1 && s[left] == s[right])
                {
                    SubStringCount++;
                    left--;
                    right++;
                }
            }
            return SubStringCount;
        }
    }
}