using BookSalesProjectEFCore.DAL.IRepositories;
using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSalesProjectEFCore.DAL.Repositories
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        
    }
}
