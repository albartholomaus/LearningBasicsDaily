using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Factory_pattern
{
    // product 
    public abstract class DiscountService//could be a Interface 
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;//for testing 

    }
   
    //concreate product, this is where we implment the discount service 
    public class CountryCodeService : DiscountService
    {
        private readonly string _countryCodeIdentifer;
        public CountryCodeService(string countryIdentifer)
        {
            _countryCodeIdentifer = countryIdentifer;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryCodeIdentifer)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }

    }
   
    // concreate product number 2, this is to demo that we can use this to make more then one service
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
   
    //creator an abstract class or interface
   
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();

    }
  
    
    //concrate crator
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _CI;
        public CountryDiscountFactory(string ci)
        {
            _CI = ci;
            
        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryCodeService(_CI);
        }
    }

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
