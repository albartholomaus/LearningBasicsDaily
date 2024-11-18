using LearningBasics.Patterns.Structural.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Facade.FacadeClass
{
    public class DiscountFacade
    {
        private readonly OrderService orderservice = new();
        private readonly CustomerDiscountBaseService customerDiscountBaseService = new();
        private readonly DayofTheWeekService dayofTheWeekService = new();

        public double TotalDiscount(int customerId)
        {
            if (!orderservice.HasEnoughOrders(customerId))
            {
                return 0;
            }
            return customerDiscountBaseService.CalculateDiscountBase(customerId) * dayofTheWeekService.CalculateDayOfTheWeekFactor();

        }
    }
}
