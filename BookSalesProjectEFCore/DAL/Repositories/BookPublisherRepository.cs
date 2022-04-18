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
                List<Book> books = sql.Books.ToList();
                bool isOk = false;
                foreach (var item in books)
                {
                    if (item.Name != name)
                    {
                        isOk = true; break;
                    }
                }
                if (isOk)
                {
                    if (!sql.Books.Any(p => p.Name == name))
                    {
                        Console.WriteLine("There is no book like this name");
                    }
                    Book book = sql.Books.SingleOrDefault(b => b.Name == name);
                    return book.Id;
                }
                else Console.WriteLine("The book by this name already exists"); return -1;
            }
        }

        public int FindPublisherIdWithName(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Publisher> publishers = sql.Publishers.ToList();
                bool isOk = false;
                foreach (var item in publishers)
                {
                    if (item.Name != name)
                    {
                        isOk = true; break;
                    }
                }
                if (isOk)
                {
                    if (!sql.Publishers.Any(p => p.Name == name))
                    {
                        Console.WriteLine("There is no publisher like this name");
                    }
                    Publisher publisher = sql.Publishers.SingleOrDefault(p => p.Name == name);
                    return publisher.Id;
                }
                else Console.WriteLine("The publisher by this name already exists"); return -1;
            }
        }
    }
}
