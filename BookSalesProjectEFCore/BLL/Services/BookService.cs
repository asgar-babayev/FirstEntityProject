using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository) => this.bookRepository = bookRepository;
        public void Add(Book entity) => bookRepository.Add(entity);
        public void Delete(int id) => bookRepository.Delete(id);
        public List<Book> GetAll() => bookRepository.GetAll();
        public List<Book> GetAll(Expression<Func<Book, bool>> expression) => bookRepository.GetAll(expression);
        public Book GetBookGenresInfo() => bookRepository.GetBookGenresInfo();
        public Book GetBookAuthorsInfo() => bookRepository.GetBookAuthorsInfo();
        public Book GetPublisherBooksInfo() => bookRepository.GetPublisherBooksInfo();
        public Book GetById(int id) => bookRepository.GetById(id);
        public void Update(Book entity) => bookRepository.Update(entity);
    }
}
