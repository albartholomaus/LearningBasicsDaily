using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Builder.Builder
{
    public abstract class CarBuilder
    {
        public Product.Car Car { get; private set; }
        public CarBuilder(string carType)
        {
            Car = new Product.Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();

    }
}
