using BookSalesProjectEFCore.BLL.IServices;
using BookSalesProjectEFCore.DAL.Repositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.BLL.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly PurchaseRepository purchaseRepository;
        public PurchaseService(PurchaseRepository purchaseRepository) => this.purchaseRepository = purchaseRepository;
        public void Add(Purchase entity) => purchaseRepository.Add(entity);
        public void Delete(int id) => purchaseRepository.Delete(id);
        public List<Purchase> GetAll() => purchaseRepository.GetAll();
        public Purchase GetById(int id) => purchaseRepository.GetById(id);
        public Purchase GetPurchasesBookInfo() => purchaseRepository.GetPurchasesBookInfo();
        public void Update(Purchase entity) => purchaseRepository.Update(entity);
    }
}
