using LearningBasics.Patterns.Structural.Decorator.ConcreteComponents;
using LearningBasics.Patterns.Structural.Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator
{
    public class ClientCode
    {
        public void Call()
        {
            //default behavior
            var cloudMailService = new CloudMailService();
            cloudMailService.SendMail("Hi there");

            var onPremMailService = new OnPremMailService();
            onPremMailService.SendMail("Hi there");

            //added behavior
            var statsDecorator = new StatsDecorator(cloudMailService);
            statsDecorator.SendMail($"sent via {nameof(StatsDecorator)} wrapper ");

            var messageDatabaseDecorator = new MessageDataBase(onPremMailService);

            messageDatabaseDecorator.SendMail($"sent via {nameof(StatsDecorator)} wrapper, message 1");
            messageDatabaseDecorator.SendMail($"sent via {nameof(StatsDecorator)} wrapper, message 2");

            foreach (var message in messageDatabaseDecorator.SentMessages)
            {
                Console.WriteLine($"stored message:{message}");
            }


        }
    }
}
