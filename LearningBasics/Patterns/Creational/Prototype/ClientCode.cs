using LearningBasics.Patterns.Creational.Prototype.ConcretePrototype1;
using LearningBasics.Patterns.Creational.Prototype.ConcretePrototype2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Prototype
{
    public class ClientCode
    {
        public void Call()
        {
            var manager = new Manager("Cindy");
            var managerClone = (Manager)manager.Clone();
            Console.WriteLine($"manager was cloned: {managerClone.Name}");

            var employee = new Employee("Kevin", managerClone);
            var employeeClone = (Employee)employee.Clone(true);
            Console.WriteLine($"Employee was cloned:{employee.Name} and the Manager {employeeClone.Manger.Name}");

            //example of a shallow copy 
            managerClone.Name="Karen";
            Console.WriteLine($"Employee was cloned:{employee.Name} and the Manager {employeeClone.Manger.Name}");

        }
    }
}
