using LearningBasics.Patterns.Structural.Decorator.Component;
using LearningBasics.Patterns.Structural.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator.ConcreteDecorator
{
    public class MessageDataBase : MailServiceDecoratorBase
    {
        public List<string> SentMessages { get; private set; } = new();
        public MessageDataBase(IMailService mailService) : base(mailService)
        { }
        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                SentMessages.Add(message);
                return true;
            }
            return false;
        }


    }
}
