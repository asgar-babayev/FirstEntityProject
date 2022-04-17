using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;
        public AuthorService(IAuthorRepository authorRepository) => this.authorRepository = authorRepository;
        public void Add(Author entity) => authorRepository.Add(entity);
        public void Delete(int id) => authorRepository.Delete(id);
        public List<Author> GetAll() => authorRepository.GetAll();
        public Author GetById(int id) => authorRepository.GetById(id);
        public void Update(Author entity) => authorRepository.Update(entity);
    }
}
