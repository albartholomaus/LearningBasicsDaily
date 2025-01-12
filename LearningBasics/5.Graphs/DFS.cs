using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._5.Graphs
{
    public class DFS
    {
        int[,] grid = { { 0, 0, 0, 0 }, { 1, 1, 0, 0 }, { 0, 0, 0, 1 }, { 0, 1, 0, 0 } };
        int[][] grid2 = [[0, 0, 0, 0], [1, 1, 0, 0], [0, 0, 0, 1], [0, 1, 0, 0]];
        int[][] GridVisited = [[0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0]];
        //  HashSet<int[][]> HashSetVisited = new HashSet<int[][]>([[0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0]]);
        int[][] array1 = new int[][] { new int[] { }, new int[] { }, new int[] { }, new int[] { } };
        public DFS()
        {
            //  HashSetVisited.Add(array1);
            //DfsP(grid2, 0, 0, GridVisited);
        }
        public int DFSmethod(int[][] grid, int row, int column, int[][] visited)
        {
            int Rows = grid.Length, COLS = grid[0].Length;//grid[0].Length is getting the legth of the one array so this is all you need 
            //dead end base case 
            if (Math.Min(row, column) < 0 //if outside the grid on the left 
                || row == Rows || column == COLS //if we have gone out of the row or out of the column,
                || visited[row][column] == 1 // if we have visited already this could be a hash set <----need to do this 
                || grid[row][column] == 1)//if we are blocked, 1 == blocked 0 means open 
            {
                return 0;
            }
            //base case for destination, in this case we are looking for the bottom right most index and a path to it if any. 
            if (row == Rows - 1 && column == COLS - 1)
            {
                return 1;
            }

            visited[row][column] = 1;//adding to visited 
            int count = 0;
            count += DFSmethod(grid, row + 1, column, visited);
            count += DFSmethod(grid, row - 1, column, visited);
            count += DFSmethod(grid, row, column + 1, visited);
            count += DFSmethod(grid, row, column - 1, visited);

            visited[row][column] = 0;//here is the backtracking, we remove it then we can go else were , aka removing from visited 
            return count;
        }

        public int DFSP(int[][] grid, int row, int column, int[][] visited)
        {
            int rowLength = grid.Length, colLength = grid[0].Length;
            if (Math.Min(row, column) < 0 || row >= rowLength || column >= colLength || grid[row][column] == 1 || visited[row][column] == 1)
            {
                return 0;
            }
            if (row == rowLength - 1 || column == colLength - 1)
            {
                return 1;
            }
            int count = 0;
            visited[row][column] = 1;
            count += DFSP(grid, row - 1, column, visited);
            count += DFSP(grid, row + 1, column, visited);
            count += DFSP(grid, row, column - 1, visited);
            count += DFSP(grid, row, column + 1, visited);
            visited[row][column] = 0;
            return count;
        }

    }
}
