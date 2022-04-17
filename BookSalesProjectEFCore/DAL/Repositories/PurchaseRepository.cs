using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
    {
        public Purchase GetPurchasesBookInfo()
        {
            using AppDbContext context = new AppDbContext();
            return context.Purchases.Include(p => p.Book).ThenInclude(b => b.BookGenres).FirstOrDefault();
        }
    }
}
