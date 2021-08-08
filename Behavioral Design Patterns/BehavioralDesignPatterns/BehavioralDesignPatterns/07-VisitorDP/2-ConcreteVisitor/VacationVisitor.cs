using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    class VacationVisitor : IVisitor
    {
        public int NumberOfDays { get; set; }
        public VacationVisitor(int numberOfDays)
        {
            NumberOfDays = numberOfDays;
        }
        public void Visit(Employee employee)
        {
            employee.Vacation += NumberOfDays;
            Console.WriteLine(employee.Name + " vacation after VacationVisitor Visiting is " + employee.Vacation);
        }
    }
}
