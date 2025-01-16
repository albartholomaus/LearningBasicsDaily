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

        public int BruteForce(int r, int c, int rows, int cols)
        {
            if (r == rows || c == cols)
            {
                return 0;
            }
            if (r == rows - 1 && c == cols - 1)
            {
                return 1;
            }
            return BruteForce(r, c, rows, cols) + BruteForce(r, c, rows, cols);
        }

        public int Memoization(int r, int c, int rows, int cols, int[][] cache)
        {
            if (r == rows || c == cols)
            {
                return 0;
            }
            if (cache[r][c] > 0)
            {
                return cache[r][c];
            }
            if (r == rows - 1 && c == cols - 1)
            {
                return 1;
            }
            return BruteForce(r, c, rows, cols) + BruteForce(r, c, rows, cols);
        }
    }
}
