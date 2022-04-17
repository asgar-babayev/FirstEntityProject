using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BookCount { get; set; }
        public DateTime SoldDate { get; set; }
    }
}
