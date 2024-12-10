using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    public class ClientCodeCall
    {
        
        public void Call()
        {
            var belgiumshoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
            var shoppingCartBelgium = new ShoppingCart(belgiumshoppingCartPurchaseFactory);
            shoppingCartBelgium.CalculateCosts();

            var franceshoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
            var shoppingCartfrance = new ShoppingCart(franceshoppingCartPurchaseFactory);
            shoppingCartfrance.CalculateCosts();

            var USAshoppingCartPurchaseFactory = new USAShoppingCartPurchaseFactory();
            var shoppingCartUSA = new ShoppingCart(USAshoppingCartPurchaseFactory);
            shoppingCartUSA.CalculateCosts();
        }
    }
}
