using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository publisherRepository;
        public PublisherService(IPublisherRepository publisherRepository) => this.publisherRepository = publisherRepository;
        public void Add(Publisher entity) => publisherRepository.Add(entity);
        public void Delete(int id) => publisherRepository.Delete(id);
        public List<Publisher> GetAll() => publisherRepository.GetAll();
        public Publisher GetById(int id) => publisherRepository.GetById(id);
        public void Update(Publisher entity) => publisherRepository.Update(entity);
    }
}
