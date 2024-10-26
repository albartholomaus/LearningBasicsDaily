using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._1.BasicsOrBasics._1.Array
{
    public class Resize
    {
        Resize()
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8];
            ResizeArray(array);
        }

        internal int[] ResizeArray(int[] array)
        {
            int[] NewArray = new int[array.Length*2];
            for (int i = 0; i <= array.Length-1; i++)
            {
                NewArray[i] = array[i];
            }
            return NewArray;
        }
    }
}
