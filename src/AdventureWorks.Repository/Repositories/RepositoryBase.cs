using AdventureWorks.Repository.Context;
using AdventureWorks.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AdventureContext ctx;
        public RepositoryBase(AdventureContext context)
        {
            ctx = context;
        }   
        public void Add(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            ctx.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return ctx.Set<T>();
        }

        public T FindById(int id)
        {
           return ctx.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            ctx.Set<T>().Update(entity);
        }
    }
}
