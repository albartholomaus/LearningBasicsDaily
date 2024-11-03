using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Builder.Product
{
    public class Car
    {
        private List<string> parts = new List<string>();//for testing so we dont have to wright a few class for parts 
        private readonly string _carType;
        public Car(string carType) {

            _carType=carType;
        }
        public void Add(string part)
        { parts.Add(part); }

        public void Show() {
            Console.WriteLine("Parts from the Product");

            foreach (var part in parts)
            {
                  Console.WriteLine(part);
            }
        }

    }
}
