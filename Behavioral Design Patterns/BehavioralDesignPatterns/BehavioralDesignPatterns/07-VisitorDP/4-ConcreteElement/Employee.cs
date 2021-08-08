using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    public class Employee : IElement
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public int Vacation { get; set; }

        public Employee(string name, float salary, int vacation)
        {
            Name = name;
            Salary = salary;
            Vacation = vacation;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
