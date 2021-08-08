using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StateDP
{
    class SilverState : State

    {
        public SilverState(State state) :
           this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            Console.WriteLine("State = SilverState");
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource

            lowerLimit = 100.1;
            upperLimit = 1000.0;
            serviceFee = 0.15;
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
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
    }
}
