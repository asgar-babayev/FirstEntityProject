using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookGenreService : IBookGenreService
    {
        private readonly IBookGenreRepository bookGenreRepository;
        public BookGenreService(IBookGenreRepository bookGenreRepository) => this.bookGenreRepository = bookGenreRepository;
        public void Add(BookGenre entity) => bookGenreRepository.Add(entity);
        public void Delete(int id) => bookGenreRepository.Delete(id);
        public List<BookGenre> GetAll() => bookGenreRepository.GetAll();
        public BookGenre GetById(int id) => bookGenreRepository.GetById(id);
        public void Update(BookGenre entity) => bookGenreRepository.Update(entity);
    }
}
