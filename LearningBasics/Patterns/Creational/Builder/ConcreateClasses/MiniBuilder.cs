using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningBasics.Patterns.Creational.Builder;
using LearningBasics.Patterns.Creational.Builder.Builder;

namespace LearningBasics.Patterns.Creational.Builder.ConcreateClasses
{
    public class MiniBuilder : CarBuilder
    {
        public MiniBuilder(): base("mini")
        { 
            
        
        }

        public override void BuildEngine()
        {
            
        }

        public override void BuildFrame()
        {
         
        }
    }
}
