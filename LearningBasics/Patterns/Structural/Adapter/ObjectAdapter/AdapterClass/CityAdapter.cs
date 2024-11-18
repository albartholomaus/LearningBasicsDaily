using LearningBasics.Patterns.Structural.Adapter.Adaptee;
using LearningBasics.Patterns.Structural.Adapter.ExteranlClient;
using LearningBasics.Patterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Adapter.AdapterClass
{
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
       
        // for class adapter 
        public City GetCity()
        {
            var CityFromExternalSystem = base.GetCity();

            return new City($"{CityFromExternalSystem.Name}-{CityFromExternalSystem.NickName}", CityFromExternalSystem.Inhabitants);
        }


        //for object adaptor 
        ////composition 
        //public ExternalSystem ExternalSystem { get; private set; } = new();

        //public City GetCity()
        //{
        //    var CityFromExternalSystem = ExternalSystem.GetCity();

        //    return new City($"{CityFromExternalSystem.Name}-{CityFromExternalSystem.NickName}", CityFromExternalSystem.Inhabitants);
        //}
    }
}
