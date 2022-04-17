using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int? StockCount { get; set; }
        public double Price { get; set; }
        public List<BookGenre> BookGenres { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookPublisher> PublishBooks { get; set; }
    }
}
