using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.Repositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class BookPublisherService : IBookPublisherService
    {
        private readonly BookPublisherRepository bookPublisherRepository;
        public BookPublisherService(BookPublisherRepository bookPublisherRepository) => this.bookPublisherRepository = bookPublisherRepository;
        public void Add(BookPublisher entity) => bookPublisherRepository.Add(new BookPublisher { BookId = bookPublisherRepository.FindBookIdWithName(entity.Book.Name), PublisherId = bookPublisherRepository.FindPublisherIdWithName(entity.Publisher.Name)});
        public void Delete(int id) => bookPublisherRepository.Delete(id);
        public List<BookPublisher> GetAll() => bookPublisherRepository.GetAll();
        public BookPublisher GetById(int id) => bookPublisherRepository.GetById(id);
        public void Update(BookPublisher entity) => bookPublisherRepository.Update(entity);
    }
}
