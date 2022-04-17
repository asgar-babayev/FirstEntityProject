﻿using BookSalesProjectEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DAL.IRepositories
{
    public interface IPurchaseRepository : IGenericRepository<Purchase>
    {
        Purchase GetPurchasesBookInfo();
    }
}