using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Bits
{
    public class Counting_bits
    {
        public Counting_bits()
        {
            CountBits(16);


        }

        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];

            int offset = 1;
            for (int i = 1; i <= n; i++)
            {
                //update the most significant bit 
                if (offset * 2 == i) offset = i;
                //its always going to be at least one, and the "i-offset" is the math to remove what we all ready know. they add it at the index of the number we are calculating 
                result[i] = 1 + result[i - offset];
            }
            return result;
        }
    }
}
