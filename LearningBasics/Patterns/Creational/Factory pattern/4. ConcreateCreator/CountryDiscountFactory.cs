using LearningBasics.Patterns.Creational.Factory_pattern._1.Product;
using LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct;
using LearningBasics.Patterns.Creational.Factory_pattern._3.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._4._ConcreateCreator
{
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string CountryIdentifier;
        public CountryDiscountFactory(string ci)
        {
            CountryIdentifier = ci;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(CountryIdentifier);
        }
    }
}
