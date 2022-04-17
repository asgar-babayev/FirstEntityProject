using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.IServices
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
