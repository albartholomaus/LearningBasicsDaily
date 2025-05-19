using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Graphs
{
    public class PacificAtlanticClass
    {
        public PacificAtlanticClass()
        {
            int[][] heights = [
                  [4,2,7,3,4],
                  [7,4,6,4,7],
                  [6,3,5,3,6]
                ];
            Print(heights);
            var result = PacificAtlantic(heights);
        }

        private void Print(int[][] heights)
        {
            for (int row = 0; row < heights.Length; row++)
            {
                for (int col = 0; col < heights[0].Length; col++)
                {
                    Console.Write($"{heights[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        private readonly int[][] directions = new int[][] {
         new int[]{1,0 }, new int[]{0,1 },
         new int[]{-1,0 }, new int[]{0,-1 },
        };
        public List<List<int>> PacificAtlantic(int[][] heights)
        {
            int rowLength = heights.Length, colLength = heights[0].Length;
            HashSet<(int, int)> pacificHashSet = new();
            HashSet<(int, int)> atlanticHashSet = new();

            for (int col = 0; col < colLength; col++)
            {
                Dfs(0, col, pacificHashSet, heights);
                Dfs(rowLength - 1, col, atlanticHashSet, heights);

            }
            for (int row = 0; row < rowLength; row++)
            {
                Dfs(row, 0, pacificHashSet, heights);
                Dfs(row, colLength - 1, atlanticHashSet, heights);
            }

            List<List<int>> results = new();
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (pacificHashSet.Contains((row, col)) && atlanticHashSet.Contains((row, col)))
                    {
                        results.Add(new List<int> { row, col });
                    }
                }
            }
            return results;
        }

        private void Dfs(int row, int col, HashSet<(int, int)> oceanHashSet, int[][] heights)
        {
            oceanHashSet.Add((row, col));
            foreach (var dir in directions)
            {
                int neighborRow = row + dir[0], neighborCol = col + dir[1];

                if (Math.Min(neighborRow, neighborCol) >= 0 && neighborRow < heights.Length && neighborCol < heights[0].Length && !oceanHashSet.Contains((neighborRow, neighborCol)) && heights[neighborRow][neighborCol] >= heights[row][col])
                {
                    Dfs(neighborRow, neighborCol, oceanHashSet, heights);
                }
            }
        }

    }
}
//Height check
//heights[neighborRow][neighborCol] >= heights[row][col]
//Models the rule “water can only flow from higher ground to lower or equal ground.”
//Since we’re doing the DFS backwards (from the ocean inward), it’s “can neighbor flow back to me?”