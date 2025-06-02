using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Math
{
    public class Spiral_Matrix
    {//Given an m x n matrix of integers matrix, return a list of all elements within the matrix in spiral order.

        public Spiral_Matrix()
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            SpiralOrder(matrix);

        }

        public List<int> SpiralOrder(int[][] matrix)
        {
            List<int> results = new();
            int left = 0, right = matrix[0].Length;
            int top = 0, bottom = matrix.Length;

            while (left < right && top < bottom)
            {
                for (int i = left; i < right; i++)
                {
                    results.Add(matrix[top][i]);
                }
                top++;

                for (int i = top; i < bottom; i++)
                {
                    results.Add(matrix[i][right - 1]);
                }
                right--;

                if (left >= right || top >= bottom)
                {
                    break;
                }

                for (int i = right - 1; i >= left; i--)
                {
                    results.Add(matrix[bottom - 1][i]);
                }
                bottom--;
                for (int i = bottom - 1; i >= top; i--)
                {
                    results.Add(matrix[i][left]);
                }
                left++;
            }
            return results;
        }

    }
}
