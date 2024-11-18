using LearningBasics.Patterns.Structural.Decorator.Component;
using LearningBasics.Patterns.Structural.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator.ConcreteDecorator
{
    public class StatsDecorator: MailServiceDecoratorBase
    {
        public StatsDecorator(IMailService mailService) : base(mailService)
        {  }
        public override bool SendMail(string message)
        {
            //fake collecting stats
            Console.WriteLine($"collecting stat in {nameof(StatsDecorator)}");
            return base.SendMail(message);
        }


    }
}
