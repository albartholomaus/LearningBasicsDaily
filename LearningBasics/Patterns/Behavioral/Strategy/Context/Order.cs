using LearningBasics.Patterns.Behavioral.Strategy.ConcreteStrategy;
using LearningBasics.Patterns.Behavioral.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Strategy.Context
{
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IExportService? IExportService { get; set; }
        
        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
        }
        public void Export(IExportService exportService)
        {
            if (exportService is null)
            {
                throw new ArgumentNullException(nameof(exportService));
            }
            IExportService?.Export(this);
        }
    }
}
