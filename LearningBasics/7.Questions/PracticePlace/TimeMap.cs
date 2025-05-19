using LearningBasics.Patterns.Behavioral.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace
{
    public class TimeMap
    {
        Dictionary<string, List<(string, int)>> timeBased;
        public TimeMap()
        {
            timeBased = new();

        }

        public void Set(string key, string value, int timestamp)
        {
            if (!timeBased.ContainsKey(key))
            {
                timeBased[key] = new List<(string, int)>();
            }
            timeBased[key].Add((value, timestamp));

        }

        public string Get(string key, int timestamp)
        {
            if (!timeBased.ContainsKey(key))
            {
                return "";
            }
            List<(string, int)> current = timeBased[key];
            int leftPointer = 0;
            int rightPointer = current.Count - 1;
            string result = string.Empty;

            while (leftPointer <= rightPointer)
            {
                int middle = (leftPointer + rightPointer) / 2;
                if (current[middle].Item2 <= timestamp)
                {
                    result = current[middle].Item1;
                    leftPointer = middle + 1;
                }
                else
                {
                    rightPointer = middle - 1;
                }
            }
            return result;
        }
    }
}
