using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly IBookAuthorRepository bookAuthorRepository;
        public BookAuthorService(IBookAuthorRepository bookAuthorRepository) => this.bookAuthorRepository = bookAuthorRepository;
        public void Add(BookAuthor entity) => bookAuthorRepository.Add(entity);
        public void Delete(int id) => bookAuthorRepository.Delete(id);
        public List<BookAuthor> GetAll() => bookAuthorRepository.GetAll();
        public BookAuthor GetById(int id) => bookAuthorRepository.GetById(id);
        public void Update(BookAuthor entity) => bookAuthorRepository.Update(entity);
    }
}
