using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ObserverDP
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName)
        {
            UserName = userName;
        }

        public void Update()
        {
            Console.WriteLine("Hallo " + UserName + ": " + "the product you want is availble ");
        }
    }
}
