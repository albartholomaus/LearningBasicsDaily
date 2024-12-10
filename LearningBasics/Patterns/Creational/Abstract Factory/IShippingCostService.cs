using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Abstract_Factory
{
    //abstract product
    public interface IShippingCostService
    {
        public decimal ShippingCosts{ get; }
    }
}
