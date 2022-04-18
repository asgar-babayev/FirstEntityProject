using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.Repositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly BookAuthorRepository bookAuthorRepository;
        public BookAuthorService(BookAuthorRepository bookAuthorRepository) => this.bookAuthorRepository = bookAuthorRepository;
        public void Add(BookAuthor entity) => bookAuthorRepository.Add(new BookAuthor { BookId = bookAuthorRepository.FindBookIdWithName(entity.Book.Name), AuthorId = bookAuthorRepository.FindAuthorIdWithName(entity.Author.Name)});
        public void Delete(int id) => bookAuthorRepository.Delete(id);
        public List<BookAuthor> GetAll() => bookAuthorRepository.GetAll();
        public BookAuthor GetById(int id) => bookAuthorRepository.GetById(id);
        public void Update(BookAuthor entity) => bookAuthorRepository.Update(entity);
    }
}
