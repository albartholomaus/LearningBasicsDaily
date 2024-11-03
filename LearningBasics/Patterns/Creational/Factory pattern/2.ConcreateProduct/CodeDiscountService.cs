using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._2.ConcreateProduct
{
    public class CodeDiscounService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscounService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage { get => 15; }

        //creator an abstract class or interface

    }

}
