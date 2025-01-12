using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._1.BasicsOrBasics._3.Hash
{
    public class HashSet
    {
        HashSet<int> hashSet = new HashSet<int>();
        public void Put(int number)
        {
            if (hashSet.Contains(number))
            {
                Console.WriteLine("input provided is already present");
                return;
            }

            hashSet.Add(number);
        }

        public void Delete(int number)
        {
            if (!hashSet.Contains(number))
            {
                Console.WriteLine("input provided is not present");
                return;
            }
            hashSet.Remove(number);
        
        }


    }
}
