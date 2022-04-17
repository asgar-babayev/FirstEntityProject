using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookSalesProjectEFCore.DAL.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        void Add(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
