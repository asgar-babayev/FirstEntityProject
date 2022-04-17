using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public Book GetBookGenresInfo()
        {
            using AppDbContext context = new AppDbContext();
            return context.Books.Include(bg => bg.BookGenres).ThenInclude(g => g.Genre).FirstOrDefault();
        }
        public Book GetPublisherBooksInfo()
        {
            using AppDbContext context = new AppDbContext();
            return context.Books.Include(pb => pb.PublishBooks).ThenInclude(p => p.Publisher).FirstOrDefault();

        }
        public Book GetBookAuthorsInfo()
        {
            using AppDbContext context = new AppDbContext();
            return context.Books.Include(ba => ba.BookAuthors).ThenInclude(a => a.Author).FirstOrDefault();
        }
    }
}
