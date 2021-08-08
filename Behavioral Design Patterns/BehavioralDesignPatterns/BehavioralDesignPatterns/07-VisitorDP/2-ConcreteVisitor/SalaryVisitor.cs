using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    public class SalaryVisitor : IVisitor
    {
        public float Percentage { get; set; }

        public SalaryVisitor(float percentage)
        {
            Percentage = percentage;
        }


        public void Visit(Employee employee)
        {
            employee.Salary = employee.Salary + (employee.Salary * Percentage / 100);
            Console.WriteLine(employee.Name + " salary after SalaryVisitor visiting is " + employee.Salary);
        }
    }
}
