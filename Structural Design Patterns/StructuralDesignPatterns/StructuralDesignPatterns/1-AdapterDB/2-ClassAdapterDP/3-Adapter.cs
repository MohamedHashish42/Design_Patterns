using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.AdapterDB.ClassAdapterDP
{
    class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        public Employee ConverToEmployee(string[] empAsString)
        {
            var Id = Convert.ToInt32(empAsString[0]);
            var Name = empAsString[1];
            var Designation = empAsString[2];
            var Salary = Convert.ToDecimal(empAsString[3]);

            return new Employee(Id, Name, Designation, Salary);
        }

        public void ProcessCompanySalary(string[][] employeesArray)
        {
            //Adapter here convert Array of Employee to List of Employee to be able
            //to pass it to thirdPartyBillingSystem as you in the following lines

            List<Employee> listEmployee = new List<Employee>();
            listEmployee = employeesArray.ToList().Select(ConverToEmployee).ToList();

            ProcessSalary(listEmployee);
        }
    }
}
