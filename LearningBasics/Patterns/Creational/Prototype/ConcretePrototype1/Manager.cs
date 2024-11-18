using LearningBasics.Patterns.Creational.Prototype.ConcretePrototype2;
using LearningBasics.Patterns.Creational.Prototype.ProtoType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Prototype.ConcretePrototype1
{
    public class Manager : Person
    {

        public override string Name { get ; set; }

        public Manager(string name)
        {
            Name = name;
        }

       
        public override Person Clone(bool deepClone=false)
        {
            if (deepClone)
            {
                var ObjAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Manager>(ObjAsJson);
            }
            return (Person)MemberwiseClone();
        }
    }
}
