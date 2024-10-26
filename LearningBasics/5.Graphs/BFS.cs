using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._5.Graphs
{
    public class BFS
    {
        int[][] Grid = { [0, 0, 0, 0,], [1, 1, 0, 0], [0, 0, 0, 1], [0, 1, 0, 0,] };
        public BFS()
        {
            Console.WriteLine(BFSP(Grid));
        }
        public int BFSMethod(int[][] grid)
        {
            int nr = grid.Length;
            int nc = grid[0].Length;

            Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
            queue.Enqueue((0, 0));
            int length = 1;//why one because we are inserting 
            while (queue.Any())
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    (int row, int col) = queue.Dequeue();//pop to get cords
                    if (row < 0 || row >= nr || col < 0 || col >= nc || grid[row][col] == 1)//out of bounce or blocked 
                    {
                        continue;
                    }
                    if (row == nr - 1 && col == nc - 1)//goal cords 
                    {
                        return length;
                    }
                    grid[row][col] = 1;//saying we visited
                    queue.Enqueue((row - 1, col));
                    queue.Enqueue((row, col + 1));
                    queue.Enqueue((row + 1, col));
                    queue.Enqueue((row, col - 1));
                }
                length++;
            }
            return -1;
        }


        public int BFSP(int[][] grid)
        {
            int rowLength = grid.Length, colLength = grid[0].Length;
            Queue<(int row, int col)> queue = new();
            queue.Enqueue((0, 0));
            int length = 1;
            while (queue.Any())
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    (int row, int col) = queue.Dequeue();
                    if (Math.Min(row, col) < 0 || row == rowLength || col == colLength || grid[row][col] == 1)
                    {
                        continue;
                    }
                    if (row == rowLength - 1 || col == colLength - 1)
                    {
                        return length;
                    }
                    grid[row][col] = 1;
                    queue.Enqueue((row - 1, col));
                    queue.Enqueue((row, col + 1));
                    queue.Enqueue((row + 1, col));
                    queue.Enqueue((row, col - 1));
                }
                length++;
            }
            return -1;
        }
    }

}

