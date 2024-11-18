using LearningBasics.Patterns.Structural.Adapter.AdapterClass;
using LearningBasics.Patterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Adapter
{
    public  class ClientCode
    {

        public void Call()
        {
            ICityAdapter adapter = new CityAdapter();

            var city = adapter.GetCity();

            Console.WriteLine($"{city.FullName},{city.People}");
        }



    }
}
