using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.Repositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookGenreService : IBookGenreService
    {
        private readonly BookGenreRepository bookGenreRepository;
        public BookGenreService(BookGenreRepository bookGenreRepository) => this.bookGenreRepository = bookGenreRepository;
        public void Add(BookGenre entity) => bookGenreRepository.Add(new BookGenre { BookId = bookGenreRepository.FindBookIdWithName(entity.Book.Name), GenreId = bookGenreRepository.FindGenreIdWithName(entity.Genre.Name)});
        public void Delete(int id) => bookGenreRepository.Delete(id);
        public List<BookGenre> GetAll() => bookGenreRepository.GetAll();
        public BookGenre GetById(int id) => bookGenreRepository.GetById(id);
        public void Update(BookGenre entity) => bookGenreRepository.Update(entity);
    }
}
