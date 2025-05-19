using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace._2D_DP
{
    public class UniquePathsClass
    {

        public int UniquePaths(int rowIndex, int columnIndex)
        {
            int[] prevRow = new int[columnIndex];

            for (int i = rowIndex - 1; i >= 0; i--)
            {
                int[] current = new int[columnIndex];
                current[columnIndex - 1] = 1;
                for (int j = columnIndex - 2; j >= 0; j--)
                {
                    current[j] = current[j + 1] + prevRow[j];
                }
                prevRow = current;
            }
            return prevRow[0];
        }

    }
}
