using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.BackTrack
{
    public class Word_Search
    {
        private int rowLength, colLength;
        public Word_Search()
        {
            char[][] board = [ ['A', 'B', 'C', 'D'],
                               ['S', 'A', 'A', 'T'],
                               ['A', 'C', 'A', 'E' ] ];

            Exist(board, "CAT");

        }
        public bool Exist(char[][] board, string word)
        {
            rowLength = board.Length;
            colLength = board[0].Length;

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (Dfs(row, col, 0, board, word))
                    {
                        Console.WriteLine("true");
                        return true;
                    }
                }
            }
            Console.WriteLine("false");
            return false;
        }
      
        private bool Dfs(int row, int col, int wordIndex, char[][] board, string word)
        {
            PrintBoard(board);
            if (wordIndex == word.Length) return true;

            if (Math.Min(row, col) < 0 || row >= rowLength || col >= colLength || board[row][col] != word[wordIndex] || board[row][col] == '#')
            {
                return false;
            }
            board[row][col] = '#';
            PrintBoard(board);
            bool result = Dfs(row + 1, col, wordIndex + 1, board, word) ||
                          Dfs(row - 1, col, wordIndex + 1, board, word) ||
                          Dfs(row, col + 1, wordIndex + 1, board, word) ||
                          Dfs(row, col - 1, wordIndex + 1, board, word);
            PrintBoard(board);
            board[row][col] = word[wordIndex];
            return result;
        }
        public void PrintBoard(char[][] board)
        {
            Console.Clear();
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    Console.Write($"{board[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
