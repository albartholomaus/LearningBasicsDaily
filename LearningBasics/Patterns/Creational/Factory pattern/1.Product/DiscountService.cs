using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._1.Product
{
    // product 
    public abstract class DiscountService//could be a Interface 
    {
        //step:1
        //thing that needs to be created, should be abstract and defines the interface 
        public abstract int DiscountPercentage { get; }

        //because this is an abstract class we can do this and have this functionality
        public override string ToString() => GetType().Name;//for testing 

    }
    //step:2 make the concreate implementation 
}
