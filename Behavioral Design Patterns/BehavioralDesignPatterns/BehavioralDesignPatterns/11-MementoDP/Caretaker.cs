using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MementoDP
{
    public class Caretaker
    {
        private Dictionary<string,Memento> Mementos = new Dictionary <string, Memento>();
        public void CreateMemento(string StepName,Memento m)
        {
            Mementos[StepName]=m;
            //Console.WriteLine("User snapshots Maintained by CareTaker :"
            //                 + m.GetState().GetDetails());
        }
        public Memento GetMemento(string StepName)
        {
            return Mementos[StepName] ;
        }
    }
}
