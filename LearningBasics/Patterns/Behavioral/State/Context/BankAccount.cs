using LearningBasics.Patterns.Behavioral.State.ConcreteState;
using LearningBasics.Patterns.Behavioral.State.StateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.State.Context
{
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance { get { return BankAccountState.Balance; } }

        public BankAccount()
        {
            BankAccountState = new RegularState(200, this);
        }

        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }
        public void WithDraw(decimal amount)
        {
            BankAccountState.Withdraw(amount);
        }
    }
}
