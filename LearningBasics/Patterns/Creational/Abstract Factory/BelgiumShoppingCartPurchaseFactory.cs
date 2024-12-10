using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //concreate factory 
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

        public IShippingCostService CreateShippingCostsService()
        {
            return new BelgiumShippingCostService();
        }
    }

    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostService CreateShippingCostsService()
        {
            return new FranceShippingCostService();
        }
    }

    public class USAShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new USADiscountService();
        }

        public IShippingCostService CreateShippingCostsService()
        {
            return new USAShippingCostService();
        }
    }
}
