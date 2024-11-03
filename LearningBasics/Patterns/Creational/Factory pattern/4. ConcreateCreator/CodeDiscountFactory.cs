using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern._4._ConcreateCreator
{
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _Code;
        public CodeDiscountFactory(Guid code)
        {
            _Code = code;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscounService(_Code);
        }
    }
}
