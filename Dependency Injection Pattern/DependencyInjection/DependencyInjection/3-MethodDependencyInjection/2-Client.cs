using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodDependencyInjection
{

        public class EmployeeBL
        {
            public IEmployeeDAL employeeDAL;

            public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
            {
                employeeDAL = _employeeDAL;

                return employeeDAL.GetAllEmployees();
            }
        }
    
}
