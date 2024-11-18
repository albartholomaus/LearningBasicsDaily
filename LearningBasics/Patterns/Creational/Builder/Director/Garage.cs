using LearningBasics.Patterns.Creational.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Builder.Director
{
    public class Garage
    {
        private CarBuilder? _builder;
        public Garage() {
            
        
        }
        public void Construct(CarBuilder builder)
        {
            _builder = builder;
            _builder.BuildEngine();
            _builder.BuildFrame();
        }

        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}
