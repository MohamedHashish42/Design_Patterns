using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StateDP
{
    class GoldState : State
    {
        public GoldState(State state)
        {
            Console.WriteLine("state = GoldState");
            balance = state.Balance;
            account = state.Account;
            Initialize();
        }
        private void Initialize()
        {
            //Should come from a database
            lowerLimit = 1000.1;
            upperLimit = 10000000.0;
            serviceFee = 0.20;
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

            if (balance < 100.0 /*RedState lowerLimt*/)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
