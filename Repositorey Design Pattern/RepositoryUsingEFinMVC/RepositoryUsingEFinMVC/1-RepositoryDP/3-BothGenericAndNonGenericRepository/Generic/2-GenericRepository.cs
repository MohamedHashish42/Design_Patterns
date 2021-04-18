using RepositoryUsingEFinMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryUsingEFinMVC.BothGenericAndNonGenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected DbContext _context = null;
        protected DbSet<TEntity> entity = null;



        public GenericRepository(DbContext _context)
        {
            this._context = _context;
            entity = _context.Set<TEntity>();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return entity.ToList();
        }
        public TEntity GetById(int? id)
        {
            return entity.Find(id);
        }
        public void Insert(TEntity obj)
        {
            entity.Add(obj);
        }
        public void Update(TEntity obj)
        {
            entity.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            TEntity existing = entity.Find(id);
            entity.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}