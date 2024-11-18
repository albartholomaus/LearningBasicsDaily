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
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;//for testing 

    }
}
