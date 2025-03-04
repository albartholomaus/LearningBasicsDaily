using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace
{
    public class _2pointer
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length-1;
            for (int i = 0; i < s.Length; i++)
            {
                if (left > right)
                {
                  
                    return true;
                }
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                if (char.ToLower(s[left]) == char.ToLower(s[right]))
                {
                    left++;
                    right--;
                }
            }
            return false;
        } 
    }
}
