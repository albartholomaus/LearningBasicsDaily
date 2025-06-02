using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Bits
{
    internal class Number_of_One_Bits
    {
        public Number_of_One_Bits()
        {
            uint n= 10;

            HammingWeight(n);
        }

        public int HammingWeight(uint n)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((1 << i & n) != 0)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
