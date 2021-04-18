
using RepositoryUsingEFinMVC.Models;
using RRepositoryUsingEFinMVC.UnitofWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryUsingEFinMVC.UnitofWork
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBContext context) : base(context)
        {
        }
        public IEnumerable<Employee> GetEmployeesByGender(string Gender)
        {
            return entity.Where(emp => emp.Gender == Gender).ToList();
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(string Dept)
        {
            return entity.Where(emp => emp.Dept == Dept).ToList();
        }
    }
}