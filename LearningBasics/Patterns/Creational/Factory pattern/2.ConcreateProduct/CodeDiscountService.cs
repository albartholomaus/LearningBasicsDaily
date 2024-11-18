using LearningBasics.Patterns.Creational.Factory_pattern._1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct
{
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid Code;
        public CodeDiscountService(Guid code)
        {
            Code = code;
        }
        public override int DiscountPercentage { get => 15; }

        //creator an abstract class or interface

    }

}
