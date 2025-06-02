using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PatternPractice.AbstractFactory
{
    public class OnpremClient
    {
        public void Call()
        {
            
            var goodWeaponTotal = new ClientCode(new ConcreateFactoryAGoodWeapon());
            goodWeaponTotal.TotalDamage();

           
            var okWeaponTotal = new ClientCode(new ConcreateFactoryAOKWeapon());
            okWeaponTotal.TotalDamage();

           
            var badWeaponTotal = new ClientCode(new ConcreateFactoryABadWeapon());
            badWeaponTotal.TotalDamage();
        }
    }
}
