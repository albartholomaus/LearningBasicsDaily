using LearningBasics.Patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator.ConcreteComponents
{
    public class OnPremMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"{message} was sent via {nameof(OnPremMailService)}");

            return true;
        }
    }
}
