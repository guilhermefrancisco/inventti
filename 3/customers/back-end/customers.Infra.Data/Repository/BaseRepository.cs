using customers.Domain.Entities;
using customers.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customers.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType>
    {
        protected readonly CustomersContext _customersContext;
        public BaseRepository(CustomersContext customersContext) => _customersContext = customersContext;
        protected virtual IList<TEntity> Select() => _customersContext.Set<TEntity>().ToList();
        protected virtual TEntity Select(int id) => _customersContext.Set<TEntity>().Find(id);
        protected virtual void Insert(TEntity obj)
        {
            _customersContext.Set<TEntity>().Add(obj);
            _customersContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _customersContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _customersContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _customersContext.Set<TEntity>().Remove(Select(id));
            _customersContext.SaveChanges();
        }

    }
}
