using LearningBasics.Patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator.ConcreteComponents
{
    public class CloudMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"{message} was sent via {nameof(CloudMailService)}");

            return true;
        }
    }
    
}
