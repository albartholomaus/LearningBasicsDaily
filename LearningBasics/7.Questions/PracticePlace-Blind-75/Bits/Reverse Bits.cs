using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Bits
{
    public class Reverse_Bits
    {
        public Reverse_Bits()
        {
            ReverseBits(00000000000000000000000000010101);

        }

        public uint ReverseBits(uint n)
        {
            uint results = 0;
            for (int i = 0; i < 32; i++)
            {
                uint bit = (n >> i) & 1;
                results += (bit << (32 - i));
            }
            return results;
        }
    }
}
