using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //concreate Implementation
    public class BelgiumShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 20;
    }

    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 25;
    }

    public class USAShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 30;
    }
}
