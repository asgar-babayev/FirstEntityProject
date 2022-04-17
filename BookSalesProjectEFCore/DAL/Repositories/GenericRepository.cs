using BookSalesProjectEFCore.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using AppDbContext context = new AppDbContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using AppDbContext context = new AppDbContext();
            T t = context.Set<T>().Find(id);
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using AppDbContext context = new AppDbContext();
            return context.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            using AppDbContext context = new AppDbContext();
            return context.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            using AppDbContext context = new AppDbContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using AppDbContext context = new AppDbContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
