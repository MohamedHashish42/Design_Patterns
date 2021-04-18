using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.PropertyDependencyInjection
{
    public class EmployeeBL
    {
        private IEmployeeDAL _employeeDAL;

        public IEmployeeDAL employeeDataObject
        {
            set
            {
               _employeeDAL = value;
            }
            get
            {
                if (employeeDataObject == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return _employeeDAL;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return  _employeeDAL.GetAllEmployees();
        }
    }
}







