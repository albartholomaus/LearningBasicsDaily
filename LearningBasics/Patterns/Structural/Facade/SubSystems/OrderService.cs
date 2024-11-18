using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Facade.SubSystems
{
    public class OrderService
    {
        public bool HasEnoughOrders(int customer)
        {
            return customer > 5;
        }

    }
    public class CustomerDiscountBaseService()
    {
        public double CalculateDiscountBase(int customeId)
        {
            return customeId > 8 ? 10 : 20;
        }
    }
    public class DayofTheWeekService()
    {
        public double CalculateDayOfTheWeekFactor()
        {

            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:

                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }


}
