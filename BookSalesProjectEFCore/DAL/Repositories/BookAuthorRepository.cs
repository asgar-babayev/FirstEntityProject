using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class BookAuthorRepository : GenericRepository<BookAuthor>, IBookAuthorRepository { }
}
