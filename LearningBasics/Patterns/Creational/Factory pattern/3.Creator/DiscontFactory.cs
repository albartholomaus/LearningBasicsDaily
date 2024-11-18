using LearningBasics.Patterns.Creational.Factory_pattern._1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._3.Creator
{
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

}
