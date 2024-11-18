using LearningBasics.Patterns.Behavioral.State.Context;
using LearningBasics.Patterns.Behavioral.State.StateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.State.ConcreteState
{
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()},depositing {amount}");
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()},withdrawn {amount} from{Balance}");
            Balance -= amount;
            if (Balance < 0)
            {
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
