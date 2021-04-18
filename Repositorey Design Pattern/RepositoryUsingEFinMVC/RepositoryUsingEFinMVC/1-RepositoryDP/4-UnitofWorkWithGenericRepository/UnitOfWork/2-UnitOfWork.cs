using RepositoryUsingEFinMVC.Models;
using RRepositoryUsingEFinMVC.UnitofWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace RepositoryUsingEFinMVC.UnitofWork
{
    class UnitOfWork : IUnitOfWork, IDisposable

    {

        private bool _disposed;
        private string _errorMessage = string.Empty;
        private DbContextTransaction TransObj;

        private readonly EmployeeDBContext _context;
        public IEmployeeRepository Employees { get; }
        public UnitOfWork(EmployeeDBContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
        }

        public void CreateTransaction()
        {
            TransObj = _context.Database.BeginTransaction();
        }
        //If all the Transactions are completed successfuly then we need to call
        //this Commit() method to Save the changes permanently in the database
        public void Commit()
        {
            TransObj.Commit();
        }
        //If atleast one of the Transaction is Failed then we need to call this Rollback() 
        //method to Rollback the database changes to its previous state
        public void Rollback()
        {
            TransObj.Rollback();
            TransObj.Dispose();
        }
        //This Save() Method Implement DbContext Class SaveChanges method so whenever we do a transaction we need to
        //call this Save() method so that it will make the changes in the database
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        _errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                throw new Exception(_errorMessage, dbEx);
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



    }
}