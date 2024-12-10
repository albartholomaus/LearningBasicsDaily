using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //client
    public class ShoppingCart
    {
        private readonly IDiscountService discountService;
        private readonly IShippingCostService shippingCostService;
        private int orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            discountService = factory.CreateDiscountService();
            shippingCostService = factory.CreateShippingCostsService();
        }
        public void CalculateCosts()
        {
            Console.WriteLine($"total costs={orderCosts -
                (orderCosts / 100 * discountService.DiscountPercentage) + shippingCostService.ShippingCosts}");
        }
    }
}
