using LearningBasics.Patterns.Behavioral.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.Strategy.Strategy
{
    public interface IExportService
    {
        void Export(Order order);
    }
}
