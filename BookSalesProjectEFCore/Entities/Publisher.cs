using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookPublisher> publishBooks { get; set; }
    }
}
