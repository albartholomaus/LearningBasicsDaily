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
            var fatories = new List<DiscountFactory> { new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("BE")};

            foreach (var f in fatories) {
                var discuntService = f.CreateDiscountService();

                Console.WriteLine($"percentage {discuntService.DiscountPercentage}From {discuntService}");
            
            }
        }

    }
}
