using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class BookGenreRepository : GenericRepository<BookGenre>, IBookGenreRepository
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

        public int FindGenreIdWithName(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Genre> genres = sql.Genres.ToList();
                bool isOk = false;
                foreach (var item in genres)
                {
                    if (item.Name != name)
                    {
                        isOk = true; break;
                    }
                }
                if (isOk)
                {
                    if (!sql.Genres.Any(p => p.Name == name))
                    {
                        Console.WriteLine("There is no genre like this name");
                    }
                    Genre genre = sql.Genres.SingleOrDefault(p => p.Name == name);
                    return genre.Id;
                }
                else Console.WriteLine("The genre by this name already exists"); return -1;
            }
        }
    }
}
