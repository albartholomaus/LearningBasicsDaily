using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //concreate implementation
    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }
    public class USADiscountService : IDiscountService
    {
        public int DiscountPercentage => 30;
    }
}
