using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.DTOs
{
    public class AuthorUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
