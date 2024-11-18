using LearningBasics.Patterns.Creational.Builder.ConcreateClasses;
using LearningBasics.Patterns.Creational.Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Builder
{
    public class ClientCode
    {
        public void Call()
        {
            var garage = new Garage();
            var miniBuilder = new MiniBuilder();
            var BMW = new BMWBuilder();

            garage.Construct(miniBuilder);
            Console.WriteLine(miniBuilder.Car.ToString());
            garage.Construct(BMW);
            Console.WriteLine(BMW.Car.ToString());
        }
    }
}
