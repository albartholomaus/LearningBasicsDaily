using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._6.DynamicProgramming
{
    // Brute force Solution
    // Time: O(2^n), Space: O(n)
    // Where n is the number of items.
    public class KnapSackBruteForce
    {
        public static int DFS(List<int> profit, List<int> weight, int capacity)
        {
            return DfsHelper(0, profit, weight, capacity);
        }

        private static int DfsHelper(int value, List<int> profit, List<int> weight, int capacity)
        {
            if (value == profit.Count) return 0;

            //skip inem value 
            int MaxProfit = DfsHelper(value + 1, profit, weight, capacity);

            //include value
            int newCapacity = weight[value];
            if (newCapacity >= 0)
            {
                int p = profit[value] + DfsHelper(value + 1, profit, weight, newCapacity);

                MaxProfit = Math.Max(MaxProfit, p);
            }
            return MaxProfit;
        }

    }

    // Memoization Solution
    // Time: O(n * m), Space: O(n * m)
    // Where n is the number of items & m is the capacity.
    public class KnapSackMemoization
    {
        public int KnapSackMemoizationMethod(List<int> profit, List<int> weight, int capacity)
        {// A 2d array, with N rows and M + 1 columns, init with -1's
            int rows = profit.Count, cap = capacity;
            List<int[]> cache = new List<int[]>();
            for (int row = 0; row < rows; row++)
            {
                cache.Add(new int[cap+1]);
                Array.Fill(cache[row], -1);
            }
            return MemoHelper(0, profit, weight, capacity, cache);
        }

        private int MemoHelper(int value, List<int> profit, List<int> weight, int capacity, List<int[]> cache)
        {
            if (value== profit.Count)return 0;
            if (cache[value][capacity] !=1)return cache[value][capacity];

            //skip value
            cache[value][capacity]= MemoHelper(value + 1, profit, weight,capacity, cache);

            int newCap = capacity - weight[value];
            if (newCap >=0)
            {
                int p = profit[value]+ MemoHelper(value + 1, profit, weight, capacity, cache);
                //compute Max 
                cache[value][capacity] = Math.Max(cache[value][capacity],p);
            }
            return cache[value][capacity];
        }

    }

    public class KnapSackMemoizationOptamised
    {
        // Dynamic Programming Solution
        // Time: O(n * m), Space: O(n * m)
        // Where n is the number of items & m is the capacity.
        public int dp(List<int> profit, List<int> weight, int capacity)
        {
            int rows = profit.Count, cap = capacity;
            List<int[]> cache = new List<int[]>();
            for (int row = 0; row < cap; row++)
            {
                cache.Add(new int[cap + 1]);
                Array.Fill(cache[row], 0);
            }
            // Fill the first column and row to reduce edge cases
            for (int i = 0; i < rows; i++) cache[i][0]= 0;

            for (int c = 0; c < cap; c++)
            {
                if (weight[0]<=c)
                {
                    cache[0][c] = profit[0];
                }
            }
            for (int i = 1; i < cap; i++)
            {
                for (int c = 1; c <=cap; c++)
                {
                    int skip = cache[-1][c];
                    int include = 0;
                    if (c - weight[i]>=0)
                    {
                        include = profit[i] + cache[i-1][c-weight[i]];
                    }
                    cache[i][c]= Math.Max(include,skip);
                }
            }
            return cache[rows - 1][cap];
        }
        
    }
}
