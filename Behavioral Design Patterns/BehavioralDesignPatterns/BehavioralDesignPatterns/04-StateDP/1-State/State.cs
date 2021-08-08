using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StateDP
{
    abstract class State

    {
        protected Account account;
        protected double balance;
        protected double lowerLimit;
        protected double upperLimit;
        protected double serviceFee;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }
}
