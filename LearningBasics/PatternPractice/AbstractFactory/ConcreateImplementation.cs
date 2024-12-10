using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PatternPractice.AbstractFactory
{
    //concreate factory 1
    public class ConcreateFactoryAGoodWeapon : IAbstractFactoryCreateWeapon
    {
        public IAbstractProductHeavyWeapon CreateHeavyWeapon()
        {
            return new AGoodHeavyWeapon();
        }

        public IAbstractProductPrimaryWeapon CreatePrimaryWeapon()
        {
            return new AGoodPrimaryWeapon();
        }

        public IAbstractProductSecondaryWeapon CreateSecondaryWeapon()
        {
            return new AGoodSecondaryWeapon();
        }
    }
    //concreate factory 2
    public class ConcreateFactoryAOKWeapon : IAbstractFactoryCreateWeapon
    {
        public IAbstractProductHeavyWeapon CreateHeavyWeapon()
        {
            return new AOKHeavyWeapon();
        }

        public IAbstractProductPrimaryWeapon CreatePrimaryWeapon()
        {
            return new AOKPrimaryWeapon();
        }

        public IAbstractProductSecondaryWeapon CreateSecondaryWeapon()
        {
            return new AOKSecondaryWeapon();
        }
    }
    //concreate factory 3
    public class ConcreateFactoryABadWeapon : IAbstractFactoryCreateWeapon
    {
        public IAbstractProductHeavyWeapon CreateHeavyWeapon()
        {
            return new ABadHeavyWeapon();
        }

        public IAbstractProductPrimaryWeapon CreatePrimaryWeapon()
        {
            return new ABadPrimaryWeapon();
        }

        public IAbstractProductSecondaryWeapon CreateSecondaryWeapon()
        {
            return new ABadSecondaryWeapon();
        }
    }

    //concreate implementation of PrimaryWeapon
    public class AGoodPrimaryWeapon : IAbstractProductPrimaryWeapon
    {
        public long PrimaryDamage => 30;
    }
    public class AOKPrimaryWeapon : IAbstractProductPrimaryWeapon
    {
        public long PrimaryDamage => 20;
    }
    public class ABadPrimaryWeapon : IAbstractProductPrimaryWeapon
    {
        public long PrimaryDamage => 10;
    }

    //concreate implementation of SecondaryWeapon
    public class AGoodSecondaryWeapon : IAbstractProductSecondaryWeapon
    {
        public long SecondaryDamage => 30;
    }
    public class AOKSecondaryWeapon : IAbstractProductSecondaryWeapon
    {
        public long SecondaryDamage => 20;
    }
    public class ABadSecondaryWeapon : IAbstractProductSecondaryWeapon
    {
        public long SecondaryDamage => 10;
    }

    //concreate implementation of HeavyWeapon
    public class AGoodHeavyWeapon : IAbstractProductHeavyWeapon
    {
        public long HeavyDamage => 30;
    }
    public class AOKHeavyWeapon : IAbstractProductHeavyWeapon
    {
        public long HeavyDamage => 30;
    }
    public class ABadHeavyWeapon : IAbstractProductHeavyWeapon
    {
        public long HeavyDamage => 30;
    }
}
