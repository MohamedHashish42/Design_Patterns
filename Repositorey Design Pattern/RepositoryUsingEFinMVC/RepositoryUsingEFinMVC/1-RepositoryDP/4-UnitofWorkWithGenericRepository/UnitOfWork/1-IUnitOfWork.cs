using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryUsingEFinMVC.UnitofWork
{
    interface IUnitOfWork
     
    {
        IEmployeeRepository Employees { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
