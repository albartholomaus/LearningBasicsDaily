using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Creational.Prototype.ProtoType
{
    public abstract class Person
    {
        public abstract string Name { get; set; }

        //public interface IClone;
        public abstract Person Clone(bool deepClone);// remove bool parameter for shallow copy 
    }
}
