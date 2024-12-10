using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //abstract factory
    //Links to the below services aka product interfaces 
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostService CreateShippingCostsService();
    }
}
