using System;
using System.Collections.Generic;
using AutoSmart.Application.Interfaces;
using AutoSmart.Domain.Interfaces.Services;

namespace AutoSmart.Application.AppService
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(long id)
        {
            return _serviceBase.GetById(id);
        }

        public void Dispose()
        {
            _serviceBase = null;
        }
    }
}