using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class NumDecodingsClass
    {
        public NumDecodingsClass()
        {
            string s = "121";
            Console.WriteLine(NumDecodings(s));
        }

        public int NumDecodingsRec(string s) => Dfs(0, s);
        private int Dfs(int index, string s)
        {
            if (index == s.Length) return 1;
            if (s[index] == '0') return 0;


            int result = Dfs(index + 1, s);

            if (index < s.Length - 1)
            {
                if (s[index] == '1' || s[index] == '2' && s[index + 1] < '7')
                {
                    result += Dfs(index + 2, s);
                }
            }
            return result;

        }


        public int NumDecodings(string s)
        {
            Dictionary<int, int> hashMap = new();
            hashMap[s.Length] = 1;
            return DfsMemo(0, s, hashMap);

        }

        private int DfsMemo(int stringIndex, string s, Dictionary<int, int> hashMap)
        {
            
            if (hashMap.ContainsKey(stringIndex)) return hashMap[stringIndex];
            if (s[stringIndex] == '0') return 0;

            int result = DfsMemo(stringIndex + 1, s, hashMap);
            if (stringIndex < s.Length - 1)
            {
                // this is to check the 2 number because we are checking it it is then in bounce. AKA  two-digit decoding branch 
                if (s[stringIndex] == '1' || s[stringIndex] == '2' && s[stringIndex + 1] < '7')
                {
                    //by doing this, validated that this is a a valid two-digit number and now we need to find the rest of the numbers. 
                    result += DfsMemo(stringIndex + 2, s,hashMap);
                }
            }
            hashMap[stringIndex] = result;
            return result;
        }
    }
}
