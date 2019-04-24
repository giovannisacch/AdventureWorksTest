using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> FindAll();
        T FindById(int id);
        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);
    }
}
