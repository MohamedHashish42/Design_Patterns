using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.AdapterDB.ClassAdapterDP
{
    class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Rs.{0}  Salary Credited to {1} ",
                                  employee.Salary, employee.Name);
            }
        }
    }
}



