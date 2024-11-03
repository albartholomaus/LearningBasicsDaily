using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._4._ConcreateCreator
{
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _CI;
        public CountryDiscountFactory(string ci)
        {
            _CI = ci;

        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryCodeService(_CI);
        }
    }
}
