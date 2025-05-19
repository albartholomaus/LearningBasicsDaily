using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class WordBreakClass
    {
        public WordBreakClass()
        {
            string theString = "abcd";
            List<string> WordBreaklist = ["a", "abc", "b", "cd"];
            WordBreak(theString, WordBreaklist);
        }
        public bool WordBreak(string s, List<string> wordDict)
        {
            bool[] cache = new bool[s.Length + 1];
            cache[s.Length] = true;

            for (int index = s.Length - 1; index >= 0; index--)
            {
                foreach (string word in wordDict)
                {
                    if ((index + word.Length) <= s.Length && s.Substring(index, word.Length) == word)
                    {
                        cache[index] = cache[index + word.Length];
                    }
                    if (cache[index]) break;
                }
              
                   
            }
            return cache[0];
        }
    }
}

