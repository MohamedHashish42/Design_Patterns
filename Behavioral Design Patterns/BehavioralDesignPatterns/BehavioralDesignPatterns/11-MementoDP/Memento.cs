using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MementoDP
{
    public class Memento
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Memento(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }


        public Memento GetState()
        {
            return this;
        }

        public void SetState(Memento memento)
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
