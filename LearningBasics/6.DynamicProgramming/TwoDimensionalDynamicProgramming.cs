using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._6.DynamicProgramming
{
    public class TwoDimensionalDynamicProgramming
    {//Count the number of unique paths from the top left to the bottom right. You are only allowed to move down or to the right.
     // Brute Force - Time: O(2 ^ (n + m)), Space: O(n + m)

        public TwoDimensionalDynamicProgramming()
        {

            UniquePaths(3, 6);
        }

        public int BruteForce(int rowIndex, int colsIndex, int rowsLength, int colsLength)
        {
            if (rowIndex == rowsLength || colsIndex == colsLength)
            {
                return 0;
            }
            if (rowIndex == rowsLength - 1 && colsIndex == colsLength - 1)
            {
                return 1;
            }
            return BruteForce(rowIndex, colsIndex, rowsLength, colsLength) + BruteForce(rowIndex, colsIndex, rowsLength, colsLength);
        }

        public int Memoization(int rowIndex, int colLength, int rowsLength, int colsLength, int[][] cache)
        {
            if (rowIndex == rowsLength || colLength == colsLength)
            {
                return 0;
            }
            if (cache[rowIndex][colLength] > 0)
            {
                return cache[rowIndex][colLength];
            }
            if (rowIndex == rowsLength - 1 && colLength == colsLength - 1)
            {
                return 1;
            }
            cache[rowIndex][colLength] = Memoization(rowIndex + 1, colLength, rowsLength, colsLength, cache)
                                       + Memoization(rowIndex, colLength + 1, rowsLength, colsLength, cache);
            return cache[rowIndex][colLength];
        }

        // Dynamic Programming - Time: O(n * m), Space: O(m), where m is num of cols
        public int DPBottomUp(int rows, int cols)
        {
            //used to store the previous values and we dont need to have a full matrics
            int[] prevRow = new int[cols];

            //this says we start are last row, then we decrement from the bottom right moving to the left until we hit the end. 
            for (int i = rows - 1; i >= 0; i--)
            {
                //this is used for doing the current calculations. 
                int[] curRow = new int[cols];
                //because all the right most column will always be one. we make it one. 
                curRow[cols - 1] = 1;

                // then we push left, starting, cols - 2 is because we adding 1 already and we dont nedd to look at it again
                for (int j = cols - 2; j >= 0; j--)
                {
                    //adding to the current row, the previous index ([j+1] )and the row below( prevRow[j] )
                    curRow[j] = curRow[j + 1] + prevRow[j];
                }
                // moving the current caluculationa into the previous row as it is no longer needed.
                prevRow = curRow;
            }
            return prevRow[0];
        }
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
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int rowCount = obstacleGrid.Length, colLength=obstacleGrid[0].Length;
            int[] previousRow = new int[colLength];
            for (int i = rowCount-1; i >= 0; i--)
            {
                int[] current = new int[colLength];

                for (int j = colLength-2; j >= 0; j--)
                {
                    if (true)
                    {
                        //dp[i][j - 1] + dp[i - 1][j]
                    }
                    
                }
            }
            return -1;
        }
    }
}
