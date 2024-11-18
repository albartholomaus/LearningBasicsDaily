using LearningBasics.Patterns.Structural.Facade.FacadeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Facade
{
    public class ClientCode
    {
        public void Call()
        {
            var facade = new DiscountFacade();
            Console.WriteLine($"Discount for cx 1: {facade.TotalDiscount(1)}");
            Console.WriteLine($"Discount for cx 1: {facade.TotalDiscount(10)}");
        
        }

    }
}
