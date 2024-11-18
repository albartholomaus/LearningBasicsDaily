using LearningBasics.Patterns.Behavioral.Strategy.ConcreteStrategy;
using LearningBasics.Patterns.Behavioral.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Strategy
{
    public class ClientCode
    {
        public void Call()
        {
            var order = new Order("Tony",5,"Visual studio License");
            order.Export(new CSVExportService());
            order.Export(new JSONServices());
        }

    }
}
