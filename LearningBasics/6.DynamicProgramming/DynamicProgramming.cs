using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._6.DynamicProgramming
{
    public class DynamicProgramming
    {
        //one dimensional programming. 

        public DynamicProgramming()
        {
         
            int[] cache = new int[6];
            Memoization(5, cache);
        }

        // basic Fib recursion 
        public int BruteForceFib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return BruteForceFib(n - 1) + BruteForceFib(n - 2);
        }
        //top down
        public int Memoization(int n, int[] cache )// the array needs to be + 1 to the number you are attempting to solve for. while it takes additional space.. 
        {
            // base case, when we hit 1 or less we need to return
            if (n <= 1)
            {
                return n;
            }
            if (cache[n] != 0)// this checks if we have already added it to the array, of witch is O(1)
            {
                return cache[n];
            }
            cache[n] = Memoization(n - 1, cache) + Memoization(n - 2,cache);
            return cache[n];
        }
        //this is the same but with out the recrusion. bottom up
        public int DpBottomUp(int n)
        {
            //if statement here is for exceptions 
            if (n < 2)
            {
                return n;
            }
            // creating storage for the 2 variables that we needs to use to store 2 numnbers to calculate the fibinachie sequance. 
            int[] cache = [0, 1];
            //this is a stating point, we already have the fist 2 numbers and we can start from there. 
            int i = 2;
            while (i <= n)
            {
                //storing it for the later move. 
                int temp = cache[1];
                //calculating the next number in the sequance. 
                cache[1] = cache[1] + cache[2];
                //moving to the old number. 
                cache[0] = temp;
            }
            // the first index will be the last to be calculated. 
            return cache[1];
        }

        //number = 5, times = 5
        public int MultiplyUsingRecrusion(int number, int times)
        {
            if (times <= 1)
            {
                return number;
            }

            return number += MultiplyUsingRecrusion(number, times - 1);
        }
    }

}
