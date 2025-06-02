using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Math
{
    public class Set_Matrix_Zeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            int totalRows = matrix.Length, totalCols = matrix[0].Length;
            //because we can use both 
            bool rowZero = false;

            //determine what row and col needs to be zero 
            for (int row = 0; row < totalRows; row++)
            {
                for (int cols = 0; cols < totalCols; cols++)
                {
                    if (matrix[row][cols] == 0)
                    {
                        //sets to to 0 
                        matrix[0][cols] = 0;
                        if (row > 0) matrix[row][0] = 0;
                        else rowZero = true;
                    }
                }
            }

            //to zero them out. 
            for (int row = 1; row < totalRows; row++)
            {
                for (int cols = 1; cols < totalCols; cols++)
                {
                    if (matrix[0][cols] == 0 || matrix[row][0] == 0)
                    {
                        matrix[row][cols]= 0;
                    }
                }
            }
            if (matrix[0][0]==0)
            {
                for (int row = 0; row < totalRows; row++)
                {
                    matrix[row][0] = 0;
                }
            }
            if (rowZero)
            {
                for (int cols = 0; cols < totalCols; cols++)
                {
                    matrix[0][cols]= 0;
                }
            }
        }

    }
}
