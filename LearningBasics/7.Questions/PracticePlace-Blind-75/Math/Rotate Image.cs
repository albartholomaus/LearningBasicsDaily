using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace_Blind_75.Math
{
    public class Rotate_Image
    {
        public Rotate_Image()
        {
            int[][] matrix = [
                              [1,2,3],
                              [4,5,6],
                              [7,8,9]
                            ];
            Rotate2(matrix);
        }
        public void Rotate(int[][] matrix)
        {
            (int left, int right) = (0, matrix.Length - 1);
            while (left < right)
            {
                var limit = right - left;
                for (int i = 0; i < limit; i++)
                {
                    (int top, int bottom) = (left, right);
                    //save
                    var topleft = matrix[top][left + 1];

                    matrix[top][left + i] = matrix[bottom - i][left];
                    matrix[top][left + i] = matrix[bottom][right - i];
                    matrix[bottom][right - i] = matrix[top + i][right];
                    matrix[top][left + i] = topleft;

                }
                left++;
                right--;

            }
            return;

        }
        public void Rotate2(int[][] matrix)
        {
            Array.Reverse(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[i].Length; j++)
                {
                    //this is a short hand swap
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);

                    //int temp = matrix[i][j];
                    //matrix[i][j]= matrix[j][i];
                    //matrix[j][i]= temp;
                }
            }
        }
    }
}
//789   749  741  741
//456   856  856  852
//123   123  923  963 