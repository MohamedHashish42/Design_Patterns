using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.PropertyDependencyInjection
{
    class PInjector
    {
        public static void TryConstructorInjector()
        {
            EmployeeBL employeeBL = new EmployeeBL();

            employeeBL.employeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}",
                                    emp.ID ,  emp.Name ,   emp.Department);
            }
  
        }
    }
}
