using LearningBasics.Patterns.Creational.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Builder.ConcreateClasses
{
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("mini")
        {


        }

        public override void BuildEngine()
        {
            Car.AddPart("v6");
        }

        public override void BuildFrame()
        {
            Car.AddPart("4 Door");
        }
    }
}
