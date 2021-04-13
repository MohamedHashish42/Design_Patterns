using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{
    class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }

        public void print()
        {
            Console.WriteLine("Emp Data \nname : {0} \nBorn : {1} \nWorking on : {2}\nStays At : {3} "
                    , employee.FullName, employee.DateOfBirth, employee.Department, employee.Address);
        }
    }
}
