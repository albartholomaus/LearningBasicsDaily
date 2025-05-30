using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class CoinChangeClass
    {

        public CoinChangeClass()
        {
            int[] coins = [1, 5, 10];

            CoinChange(coins, 12);
        }

        public int CoinChange(int[] coins, int amount)
        {
            int[] cache = new int[amount + 1];

            Array.Fill(cache, amount + 1);
            cache[0] = 0;
            for (int valueCheck = 1; valueCheck <= amount; valueCheck++)
            {
                foreach (var coin in coins)
                {
                    if (coin <= valueCheck)
                    {
                        int upcommingValue = cache[valueCheck - coin] + 1;
                        int currentvalue = cache[valueCheck];
                        cache[valueCheck] = Math.Min(currentvalue, upcommingValue);
                    }
                }
            }
            return cache[amount] > amount ? -1 : cache[amount];
        }
    }
}
