using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StateDP
{
    class Account
    {
        private State _state;
        private string _owner;

        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            _owner = owner;
            _state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return _state.Balance; }
        }

        public State State
        {
            set { _state = value; }
        }

        public void Deposit(double amount)
        {

            _state.Deposit(amount);

            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine("Balance = {0:C}", Balance);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {

            if (amount > _state.Balance)
            {
                Console.Write("Sorry you have not enough money \n");
            }
            else
            {
                _state.Withdraw(amount);

                Console.WriteLine("Withdrew {0:C} --- ", amount);
                Console.WriteLine("Balance = {0:C}", Balance);
                Console.WriteLine("");
            }
        }

    }
}

