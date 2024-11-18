using LearningBasics.Patterns.Behavioral.Strategy.Context;
using LearningBasics.Patterns.Behavioral.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Strategy.ConcreteStrategy
{
    public class JSONServices :IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} top JSON");
        }
    }

    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} top JSON");
        }
    }

    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} top JSON");
        }
    }
}
