using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MementoDP
{
    public class Originator
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(FirstName, SecondName, Age);
        }
        public void Restore(Memento memento)
        {
            FirstName = memento.FirstName;
            SecondName = memento.SecondName;
            Age = memento.Age;
        }

        public string GetDetails()
        {
            return "[ First Name " + FirstName +
                    ", Second Name= " + SecondName +
                    ", Age= " + Age + "]";
        }


    }
}
