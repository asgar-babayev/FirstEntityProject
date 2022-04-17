using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DAL.IRepositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Book GetBookGenresInfo();
        Book GetPublisherBooksInfo();
        Book GetBookAuthorsInfo();
    }
}
