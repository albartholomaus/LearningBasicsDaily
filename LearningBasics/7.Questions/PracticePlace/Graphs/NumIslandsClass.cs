using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.Graphs
{
    public class NumIslandsClass
    {
        private static readonly int[][] directions = new int[][] {
            new int[] {1,0 }, //down
            new int[] {-1,0 },//to the left
            new int[] {0,1 }, //right
            new int[] {0,-1 }//top
        };

        public NumIslandsClass()
        {
            char[][] grid = [
            ['0', '1', '1', '1', '0'],
            ['0', '1', '0', '1', '0'],
            ['1', '1', '0', '0', '0'],
            ['0', '0', '0', '0', '0']
         ];
            NumIslands(grid);
        }
        public int NumIslands(char[][] grid)
        {
            int RowLength = grid.Length, ColLength = grid[0].Length;
            int islands = 0;
            for (int row = 0; row < RowLength; row++)
            {
                for (int cols = 0; cols < ColLength; cols++)
                {
                    if (grid[row][cols] == '1')
                    {
                        Bfs(grid, row, cols);
                        islands++;
                    }
                }
            }
            return islands;
        }
        private void Bfs(char[][] grid, int row, int cols)
        {
            Queue<int[]> queue = new();

            grid[row][cols] = '0';
            queue.Enqueue(new int[] { row, cols });

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                int rowfromNode = node[0], colfromNode = node[1];

                foreach (var dir in directions)
                {
                    int newRow = rowfromNode + dir[0], newCol = colfromNode + dir[1]; //That line is what actually moves you from the current cell to each of its four neighbors.

                    //check for boarders. 
                    if (newRow >= 0 && newCol >= 0 && newRow < grid.Length && newCol < grid[0].Length && grid[newRow][newCol] == '1')
                    {

                        queue.Enqueue(new int[] { newRow, newCol });
                        grid[newRow][newCol] = '0';
                    }
                }
            }
        }
    }
}
