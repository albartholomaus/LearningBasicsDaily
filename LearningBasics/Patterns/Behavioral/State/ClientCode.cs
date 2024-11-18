using LearningBasics.Patterns.Behavioral.State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.State
{
    public class ClientCode
    {
        public void Call()
        {
            BankAccount bankAccount = new();
            bankAccount.Deposit(100);
            bankAccount.WithDraw(500);
            bankAccount.WithDraw(100);
        }
    }
}
