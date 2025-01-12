using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningBasics._99.HelperClasses;

namespace LearningBasics.BasicsOrBasics.Stack
{
    public class CatArrays
    {
        public CatArrays()
        {
            int[] arrayOne = [1, 2, 3, 4, 5, 6];
            int[] arrayTwo = [1, 2, 3, 4, 5, 6];
            int[] MergedArray = MergeArrays(arrayOne, arrayTwo);
            PrintArray.PrintArrayMethod(MergedArray);
        }

        public int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] merged = new int[array1.Length + array2.Length];
            int firstArrayIndex = 0, secondArrayIndex = 0;
            for (int i = 0; i <= (array1.Length + array2.Length) - 1; i++)
            {
                if (firstArrayIndex > array1.Length - 1)
                {
                    merged[i] = array2[secondArrayIndex++];
                }
                else if (secondArrayIndex > array2.Length - 1)
                {
                    merged[i] = array1[firstArrayIndex++];
                }
                else if (array1[firstArrayIndex] <= array2[secondArrayIndex])
                {
                    merged[i] = array1[firstArrayIndex++];
                }
                else
                {
                    merged[i] = array2[secondArrayIndex++];
                }
            }
            return merged;
        }


    }
}
