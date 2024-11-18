using LearningBasics.Patterns.Creational.Factory_pattern._1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct
{
    //concreate product, this is where we implement the discount service 
    public class CountryDiscountService : DiscountService
    {
        private readonly string CountryCodeIdentifier;
        public CountryDiscountService(string countryIdentifier)
        {
            CountryCodeIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (CountryCodeIdentifier)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }

    }
}
