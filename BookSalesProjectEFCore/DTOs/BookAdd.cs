using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DTOs
{
    public class BookAdd
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int StockCount { get; set; }
        public double Price { get; set; }
    }
}
