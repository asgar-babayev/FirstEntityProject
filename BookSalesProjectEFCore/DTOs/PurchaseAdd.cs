using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DTOs
{
    public class PurchaseAdd
    {
        public int BookId { get; set; }
        public int BookCount { get; set; }
        public DateTime SoldDate { get; set; }
    }
}
