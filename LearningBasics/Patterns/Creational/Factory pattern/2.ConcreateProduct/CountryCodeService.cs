using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct
{
    //concreate product, this is where we implment the discount service 
    public class CountryCodeService : DiscountService
    {
        private readonly string _countryCodeIdentifer;
        public CountryCodeService(string countryIdentifer)
        {
            _countryCodeIdentifer = countryIdentifer;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryCodeIdentifer)
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
