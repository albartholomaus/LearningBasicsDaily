using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PatternPractice.AbstractFactory
{
    public class ClientCode
    {
        private readonly IAbstractProductPrimaryWeapon primaryWeapon;
        private readonly IAbstractProductSecondaryWeapon secondaryWeapon;
        private readonly IAbstractProductHeavyWeapon heavyWeapon;
        private long totalDamage;

        public ClientCode(IAbstractFactoryCreateWeapon weapon)
        {
            primaryWeapon = weapon.CreatePrimaryWeapon();
            secondaryWeapon = weapon.CreateSecondaryWeapon();
            heavyWeapon = weapon.CreateHeavyWeapon();
        }
        public void TotalDamage()
        {
            totalDamage = primaryWeapon.PrimaryDamage + secondaryWeapon.SecondaryDamage + heavyWeapon.HeavyDamage;
            Console.WriteLine($"total damage is: {totalDamage}");
        
        }
    }
}
