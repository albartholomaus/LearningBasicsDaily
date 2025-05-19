using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.BackTracking
{
    public class BackTracking
    {
        public List<string> GenerateParenthesisDP(int n)
        {
            List<List<string>> results = new();
            for (int i = 0; i < n; i++)
            {
                results.Add(new List<string>());
            }
            results[0].Add("");
            for (int k = 0; k <= n; k++)
            {
                for (int i = 0; i < k; i++)
                {
                    foreach (var left in results[i])
                    {
                        foreach (string right in results[k - i - 1])
                        {
                            results[k].Add("(" + left + ")" + right);
                        }
                    }
                }
            }
            return results[n];
        }
        public List<string> GenerateParenthesis(int n)
        {
            List<string> result = new();
            Generate(result, "", 0, 0, n);
            return result;

        }
        private void Generate(List<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }
            if (open < max)
            {
                Generate(result, current + "(", open + 1, close, max);
            }
            if (close < open)
            {
                Generate(result, current + ")", open, close + 1, max);
            }
        }
    }
}
