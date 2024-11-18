using LearningBasics.Patterns.Creational.Prototype.ConcretePrototype1;
using LearningBasics.Patterns.Creational.Prototype.ProtoType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Prototype.ConcretePrototype2
{
    public class Employee : Person
    {
        public  Manager Manger { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manger = manager;
        }


        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var ObjAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(ObjAsJson);
            }
            return (Person)MemberwiseClone();
        }
    }
}
