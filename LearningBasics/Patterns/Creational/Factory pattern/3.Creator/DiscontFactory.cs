using LearningBasics.Patterns.Creational.Factory_pattern._1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._3.Creator
{
    //the creator declares the factory method and MUST return the product. in this specific case it is the discount factory
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
    //https://stackoverflow.com/questions/1519358/when-to-use-factory-method-pattern
}
