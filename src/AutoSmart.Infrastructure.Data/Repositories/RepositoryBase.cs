using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoSmart.Domain.Interfaces.Repositories;
using AutoSmart.Infrastructure.Data.Context;

namespace AutoSmart.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly AutoSmartContext _context = new AutoSmartContext();

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
