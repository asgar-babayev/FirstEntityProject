using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DTOs
{
    public class BookUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int StockCount { get; set; }
    }
}
