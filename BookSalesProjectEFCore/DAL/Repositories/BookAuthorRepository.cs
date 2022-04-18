using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class BookAuthorRepository : GenericRepository<BookAuthor>, IBookAuthorRepository
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

        public int FindAuthorIdWithName(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Author> authors = sql.Authors.ToList();
                bool isOk = false;
                foreach (var item in authors)
                {
                    if (item.Name != name)
                    {
                        isOk = true; break;
                    }
                }
                if (isOk)
                {
                    if (!sql.Authors.Any(p => p.Name == name))
                    {
                        Console.WriteLine("There is no author like this name");
                    }
                    Author author = sql.Authors.SingleOrDefault(p => p.Name == name);
                    return author.Id;
                }
                else Console.WriteLine("The author by this name already exists"); return -1;
            }
        }
    }
}
