using LearningBasics.Patterns.Structural.Adapter.ExteranlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Adapter.Adaptee
{
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Sioux City","Little Chicago",10000);
        
        }
    }
}
