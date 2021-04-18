using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodDependencyInjection
{
    class MInjector
    {
        public static void TryMethodInjector()
        {

            EmployeeBL employeeBL = new EmployeeBL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());

            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}",
                                   emp.ID, emp.Name, emp.Department);
            }

        }
    }
}
