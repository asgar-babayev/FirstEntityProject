using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.Entities
{
    public class BookGenre
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
