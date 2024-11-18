using LearningBasics.Patterns.Structural.Adapter.ExteranlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Adapter.Target
{
    public interface ICityAdapter
    {
        City GetCity();
    }
}
