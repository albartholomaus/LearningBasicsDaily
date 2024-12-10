using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PatternPractice.AbstractFactory
{

    public interface IAbstractFactoryCreateWeapon
    {
        //abstract factory 
        IAbstractProductPrimaryWeapon CreatePrimaryWeapon();

        IAbstractProductSecondaryWeapon CreateSecondaryWeapon();

        IAbstractProductHeavyWeapon CreateHeavyWeapon();
    }

    public interface IAbstractProductPrimaryWeapon
    {
        //abstract product for abstract factory 1
        public long PrimaryDamage { get; }
    }
    public interface IAbstractProductSecondaryWeapon
    {
        //abstract product for abstract factory 1
        public long SecondaryDamage { get; }
    }

    public interface IAbstractProductHeavyWeapon
    {
        //abstract product for abstract factory 1
        public long HeavyDamage { get; }
    }
}
