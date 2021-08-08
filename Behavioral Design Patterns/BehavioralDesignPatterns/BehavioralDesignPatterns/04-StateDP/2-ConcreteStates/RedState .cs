using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StateDP
{
    class RedState : State

    {
        public RedState(State state)
        {
            Console.WriteLine("State = RedState");
            balance = state.Balance;
            account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            lowerLimit = 0.0;
            upperLimit = 100.0;
            serviceFee = 0.05;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount + serviceFee;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
