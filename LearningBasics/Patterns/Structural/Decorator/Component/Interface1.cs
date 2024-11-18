using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Structural.Decorator.Component
{
    public interface IMailService
    {
        bool SendMail(string message);
    }
}
