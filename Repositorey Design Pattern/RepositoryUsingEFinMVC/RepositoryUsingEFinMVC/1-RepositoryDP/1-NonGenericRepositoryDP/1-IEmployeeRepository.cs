using RepositoryUsingEFinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryUsingEFinMVC.RepositoryDP.NonGenericRepositoryDP
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int? EmployeeID);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);

        void Dispose();
        void Save();
    }
}
