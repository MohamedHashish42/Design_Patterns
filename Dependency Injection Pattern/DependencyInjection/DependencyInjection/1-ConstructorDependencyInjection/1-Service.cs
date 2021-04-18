using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee() { ID = 1, Name = "Pranaya", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Kumar", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Rout", Department = "Payroll" });
            return ListEmployees;
        }
    }

}
