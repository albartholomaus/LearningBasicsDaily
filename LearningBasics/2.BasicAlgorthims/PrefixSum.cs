using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._2.BasicAlgorthims
{
    public class PrefixSum
    {
        List<int> prefix;
        public PrefixSum(int[] nums)
        {
            prefix = new List<int>();
            int total = 0;
            foreach (int number in nums)
            {
                total += number;
                prefix.Add(total);
            }
            Console.WriteLine(RangeSum(2, 3));
        }

        public int RangeSum(int left, int right)
        {
            //find the right number 
            int preRight = prefix[right];
            //we need the left -1 to remove the index's that should be excluded. 
            int preleft = left > 0 ? prefix[left - 1] : 0;
            //the return math
            return (preRight - preleft);
        }
        //Given an integer array nums, handle multiple queries of the following type
        // Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
        public class NumArray
        {
            List<int> prefix = new();
            public NumArray(int[] nums)
            {
                int total = 0;
                foreach (var number in nums)
                {
                    total += number;
                    prefix.Add(total);
                }
                SumRange(0, 2);
            }

            public int SumRange(int left, int right)
            {
                int rightIndexNumber = prefix[right];
                int leftIndexNumber = left > 0 ? prefix[left - 1] : 0;
                int retunNumber = rightIndexNumber - leftIndexNumber; ;
                return retunNumber;
            }
        }
        public class NumMatrix
        {
            private int[,] sumMatrix;
            public NumMatrix(int[][] matrix)
            {
                int RowLength = matrix.Length, colLength = matrix[0].Length;
                //here we are making an edge case rule, so we can get the do some if statements to account for the fact we can't a from a row or column that is not there. 
                sumMatrix = new int[RowLength + 1, colLength + 1];
                for (int row = 0; row < RowLength; row++)
                {
                    int prefix = 0;
                    for (int col = 0; col < colLength; col++)
                    {
                        prefix += matrix[row][col];
                        int above = sumMatrix[row, col + 1];
                        sumMatrix[row + 1, col + 1] = prefix + above;
                    }
                }
            }
            //the parmarters here are for the starting point row 1 and col1 and the end point , row 2 and col 2
            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                // toaccount for the adding of the row and col above we need to add 1 to every field 
                row1++; row2++;col1++;col2++;
                
                int bottomRight = sumMatrix[row2, col2];
                int above = sumMatrix[row1-1, col2];
                int left = sumMatrix[row2, col1-1];
                int topleft = sumMatrix[row1-1, col1-1];
                //why this? because there is some over lap 
                return bottomRight - above - left + topleft;
            }
        }
    }
}
