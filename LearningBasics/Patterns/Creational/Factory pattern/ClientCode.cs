using LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct;
using LearningBasics.Patterns.Creational.Factory_pattern._3.Creator;
using LearningBasics.Patterns.Creational.Factory_pattern._4._ConcreateCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern
{
    public class ClientCode
    {

        public void CallFactories()
        {
            var factories = new List<DiscountFactory> { new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("BE")};

            foreach (var f in factories) {
                var discountService = f.CreateDiscountService();

                Console.WriteLine($"percentage {discountService.DiscountPercentage}From {discountService}");
            
            }
        }

    }
}
