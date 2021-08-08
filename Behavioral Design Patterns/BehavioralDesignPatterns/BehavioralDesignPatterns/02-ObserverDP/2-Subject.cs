using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ObserverDP
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _name;
        private int _price;
        state _state;
        public Subject(string name, int price, state state)
        {
            _name = name;
            _price = price;
            _state = state;
        }


        public void Attach(IObserver observer)
        {
            Console.WriteLine("New observer added");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public state getState()
        {
            return _state;
        }

        public void setState(state state)
        {
            _state = state;
            Console.WriteLine("State changed from Not Available to Available.\n");
            Notify();
        }
    }
}
