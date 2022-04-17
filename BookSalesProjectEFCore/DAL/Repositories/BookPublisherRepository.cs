using BookSalesProjectEFCore.Entities;
using BookSalesProjectEFCore.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class BookPublisherRepository : GenericRepository<BookPublisher>, IBookPublisherRepository
    {

        public int FindBookIdWithName(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                if (!sql.Books.Any(p => p.Name == name))
                {
                    Console.WriteLine("There is no book like tihs name");
                    throw new Exception();
                }
                Book book = sql.Books.SingleOrDefault(b => b.Name == name);
                return book.Id;
            }
        }
        
        public int FindPublisherIdWithName(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                if (!sql.Publishers.Any(p => p.Name == name))
                {
                    Console.WriteLine("There is no book like tihs name");
                    throw new Exception();
                }
                Publisher publisher = sql.Publishers.SingleOrDefault(p => p.Name == name);
                return publisher.Id;
            }
        }
    }
}
