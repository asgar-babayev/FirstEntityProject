using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository genreRepository;
        public GenreService(IGenreRepository genreRepository) => this.genreRepository = genreRepository;
        public void Add(Genre entity) => genreRepository.Add(entity);
        public void Delete(int id) => genreRepository.Delete(id);
        public List<Genre> GetAll() => genreRepository.GetAll();
        public Genre GetById(int id) => genreRepository.GetById(id);
        public void Update(Genre entity) => genreRepository.Update(entity);
    }
}
