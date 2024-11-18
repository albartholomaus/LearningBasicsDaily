using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Adapter.ExteranlClient
{
    public class City
    {
        public string FullName { get; private set; }
        public long People { get; private set; }

        public City(string fullName, long people)
        {
            FullName = fullName;
            People = people;
        
        }
    }
}
