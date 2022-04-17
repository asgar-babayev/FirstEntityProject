using System;
using BookSalesProjectEFCore.BLL.Services;
using BookSalesProjectEFCore.Core;
using BookSalesProjectEFCore.DAL.Repositories;
using BookSalesProjectEFCore.DTOs;
using BookSalesProjectEFCore.Entities;

namespace BookSalesProjectEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            do
            {
                Console.WriteLine(@"0 - Quit
1 - Book Crud
2 - Author Crud
3 - Genre Crud
4 - Publisher Add
5 - Buy the book");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                        BookCrud();
                        break;
                    case 2:
                        AuthorCrud();
                        break;
                    case 3:
                        GenreCrud();
                        break;
                    case 4:
                        PublisherAdd publisher = new PublisherAdd();
                        AddPublisher(ref publisher);
                        break;
                    case 5:
                        PurchaseAdd purchaseAdd = new PurchaseAdd();
                        AddPurchase(ref purchaseAdd);
                        break;
                    default:
                        break;
                }
            } while (choise != 0);
        }

        static void BookCrud()
        {
            int choise = 0;
            do
            {
                Console.WriteLine(@"0 - Quit
1 - Create 
2 - Read
3 - Update
4 - Delete");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                        BookAdd bookAdd = new BookAdd();
                        AddBook(ref bookAdd);
                        break;
                    case 2:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Books info");
                        GetBooks();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Book and genres info:");
                        GetBookAndGenres();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Book and authors info:");
                        GetBookAndAuthors();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Book and publishers info:");
                        GetBookAndPublishers();
                        break;
                    case 3:
                        int id = 0;
                        UpdateBook(ref id);
                        break;
                    case 4:
                        int delId = 0;
                        GetBooks();
                        Console.WriteLine("Which you want delete book:");
                        DeleteBook(ref delId);
                        break;
                    default:
                        break;
                }
            } while (choise != 0);
        }
        static void AuthorCrud()
        {
            int choise = 0;
            do
            {
                Console.WriteLine(@"0 - Quit
1 - Create 
2 - Read
3 - Update
4 - Delete");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                        AuthorAdd authorAdd = new AuthorAdd();
                        AddAuthor(ref authorAdd);
                        break;
                    case 2:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Authors info");
                        GetAuthors();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 3:
                        int id = 0;
                        UpdateAuthor(ref id);
                        break;
                    case 4:
                        int delId = 0;
                        GetAuthors();
                        Console.WriteLine("Which you want delete author:");
                        DeleteAuthor(ref delId);
                        break;
                    default:
                        break;
                }
            } while (choise != 0);
        }
        static void GenreCrud()
        {
            int choise = 0;
            do
            {
                Console.WriteLine(@"0 - Quit
1 - Create 
2 - Read
3 - Update
4 - Delete");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                        GenreAdd genreAdd = new GenreAdd();
                        AddGenre(ref genreAdd);
                        break;
                    case 2:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Genres info");
                        GetGenres();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 3:
                        int id = 0;
                        UpdateAuthor(ref id);
                        break;
                    case 4:
                        int delId = 0;
                        GetGenres();
                        Console.WriteLine("Which you want delete genre:");
                        DeleteAuthor(ref delId);
                        break;
                    default:
                        break;
                }
            } while (choise != 0);
        }
        static void AddPublisher(ref PublisherAdd publisher)
        {
            PublisherService publisherService = new PublisherService(new PublisherRepository());
        SetName:
            Console.Write("Enter publisher name: ");
            publisher.Name = Console.ReadLine();
            if (string.IsNullOrEmpty(publisher.Name)) { Console.WriteLine("Enter again"); goto SetName; }
            publisherService.Add(AutoMapperProfile.MapperConfigure<Publisher, PublisherAdd>(publisher));
        }
        static void AddGenre(ref GenreAdd genre)
        {
            GenreService genreService = new GenreService(new GenreRepository());
        SetGenreName:
            Console.Write("Enter genre name: ");
            genre.Name = Console.ReadLine();
            if (string.IsNullOrEmpty(genre.Name)) { Console.WriteLine("Enter again"); goto SetGenreName; }
            genreService.Add(AutoMapperProfile.MapperConfigure<Genre, GenreAdd>(genre));
        }
        static void AddAuthor(ref AuthorAdd author)
        {
            AuthorService authorService = new AuthorService(new AuthorRepository());
        SetName:
            Console.Write("Enter name: ");
            author.Name = Console.ReadLine();
            if (string.IsNullOrEmpty(author.Name)) { Console.WriteLine("Enter again"); goto SetName; }
        SetSurname:
            Console.Write("Enter surname: ");
            author.Surname = Console.ReadLine();
            if (string.IsNullOrEmpty(author.Surname)) { Console.WriteLine("Enter again"); goto SetSurname; }
            authorService.Add(AutoMapperProfile.MapperConfigure<Author, AuthorAdd>(author));
            GetAuthors();
        }
        static void GetAuthors()
        {
            AuthorService authorService = new AuthorService(new AuthorRepository());
            var authors = authorService.GetAll();
            bool isOK = false;
            foreach (Author author in authors)
            {
                if (author != null)
                {
                    Console.WriteLine($"{author.Id}. {author.Name} {author.Surname}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void GetGenres()
        {
            GenreService genreService = new GenreService(new GenreRepository());
            var genres = genreService.GetAll();
            bool isOK = false;
            foreach (Genre genre in genres)
            {
                if (genre != null)
                {
                    Console.WriteLine($"{genre.Id}. {genre.Name}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void UpdateAuthor(ref int id)
        {
            int choise = -1;
            Author a;
            AuthorService authorService = new AuthorService(new AuthorRepository());
            GetBooks();
            Console.Write("Select the id you want to update: ");
        SetId:
            SetChoise(ref id);
            try
            {
                a = authorService.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SetId;
            }
            while (choise != 0)
            {
                Console.WriteLine("Select what you want to update(0-Quit, 1-Name, 2-Surname)");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                    SetName:
                        Console.Write("Enter author name: ");
                        a.Name = Console.ReadLine();
                        if (string.IsNullOrEmpty(a.Name)) { Console.WriteLine("Enter again"); goto SetName; }
                        authorService.Update(AutoMapperProfile.MapperConfigure<Author, AuthorUpdate>(a));
                        GetBooks();
                        break;
                    case 2:
                        SetSurname:
                        Console.Write("Enter author surname: ");
                        a.Surname = Console.ReadLine();
                        if (string.IsNullOrEmpty(a.Surname)) { Console.WriteLine("Enter again"); goto SetSurname; }
                        authorService.Update(AutoMapperProfile.MapperConfigure<Author, AuthorUpdate>(a));
                        GetBooks();
                        break;
                    default:
                        break;
                }
            }
        }
        static void DeleteAuthor(ref int delId)
        {
            AuthorService authorService = new AuthorService(new AuthorRepository());
            SetChoise(ref delId);
            authorService.Delete(delId);
            GetBooks();
            Console.WriteLine("Author deleted");
        }
        static void DeleteGenre(ref int delId)
        {
            GenreService genreService = new GenreService(new GenreRepository());
            SetChoise(ref delId);
            genreService.Delete(delId);
            GetBooks();
            Console.WriteLine("Genre deleted");
        }
        static void AddBook(ref BookAdd book)
        {
            BookService bookService = new BookService(new BookRepository());
        SetName:
            Console.Write("Enter book name: ");
            book.Name = Console.ReadLine();
            if (string.IsNullOrEmpty(book.Name)) { Console.WriteLine("Enter again"); goto SetName; }
        SetPageCount:
            try
            {
                Console.Write("Enter page count: ");
                book.PageCount = Convert.ToInt32(Console.ReadLine());
                if (book.PageCount < 0) { Console.WriteLine("Enter again"); goto SetPageCount; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto SetPageCount;
            }
        SetStockCount:
            try
            {
                Console.Write("Enter stock count: ");
                book.StockCount = Convert.ToInt32(Console.ReadLine());
                if (book.StockCount < 0) { Console.WriteLine("Enter again"); goto SetStockCount; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto SetStockCount;
            }
        SetPrice:
            try
            {
                Console.Write("Enter price: ");
                book.Price = Convert.ToInt32(Console.ReadLine());
                if (book.Price< 0) { Console.WriteLine("Enter again"); goto SetPrice; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto SetPrice;
            }
            bookService.Add(AutoMapperProfile.MapperConfigure<Book, BookAdd>(book));
            GetBooks();
        }
        static void UpdateBook(ref int id)
        {
            int choise = -1;
            Book b;
            BookService bookService = new BookService(new BookRepository());
            GetBooks();
            Console.Write("Select the id you want to update: ");
        SetId:
            SetChoise(ref id);
            try
            {
                b = bookService.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SetId;
            }
            while (choise != 0)
            {
                Console.WriteLine("Select what you want to update(0-Quit, 1-Name, 2-Page Count, 3-Stock Count)");
                SetChoise(ref choise);
                switch (choise)
                {
                    case 1:
                    SetName:
                        Console.Write("Enter book name: ");
                        b.Name = Console.ReadLine();
                        if (string.IsNullOrEmpty(b.Name)) { Console.WriteLine("Enter again"); goto SetName; }
                        bookService.Update(AutoMapperProfile.MapperConfigure<Book, BookUpdate>(b));
                        GetBooks();
                        break;
                    case 2:
                    SetPageCount:
                        try
                        {
                            Console.Write("Enter page count: ");
                            b.PageCount = Convert.ToInt32(Console.ReadLine());
                            if (b.PageCount < 0) { Console.WriteLine("Enter again"); goto SetPageCount; }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            goto SetPageCount;
                        }
                        bookService.Update(AutoMapperProfile.MapperConfigure<Book, BookUpdate>(b));
                        GetBooks();
                        break;
                    case 3:
                    SetStockCount:
                        try
                        {
                            Console.Write("Enter stock count: ");
                            b.StockCount = Convert.ToInt32(Console.ReadLine());
                            if (b.StockCount < 0) { Console.WriteLine("Enter again"); goto SetStockCount; }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            goto SetStockCount;
                        }
                        bookService.Update(AutoMapperProfile.MapperConfigure<Book, BookUpdate>(b));
                        GetBooks();
                        break;
                    default:
                        break;
                }
            }
        } 
        static void DeleteBook(ref int delId)
        {
            BookService bookService = new BookService(new BookRepository());
            SetChoise(ref delId);
            bookService.Delete(delId);
            GetBooks();
            Console.WriteLine("Book deleted");
        }
        static void GetBooks()
        {
            BookService bookService = new BookService(new BookRepository());
            var books = bookService.GetAll();
            bool isOK = false;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Id}. {book.Name}, {book.PageCount}, {book.StockCount}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void GetBookAndGenres()
        {
            BookService bookService = new BookService(new BookRepository());
            var books = bookService.GetBookGenresInfo();
            bool isOK = false;
            foreach (var book in books.BookGenres)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Id}. {book.Book.Name}, {book.Genre.Name}, {book.Book.PageCount}, {book.Book.StockCount}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void GetBookAndAuthors()
        {
            BookService bookService = new BookService(new BookRepository());
            var books = bookService.GetBookAuthorsInfo();
            bool isOK = false;
            foreach (var book in books.BookAuthors)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Id}. {book.Author.Name} {book.Author.Surname}, {book.Book.Name}, {book.Book.PageCount}, {book.Book.StockCount}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void GetBookAndPublishers()
        {
            BookService bookService = new BookService(new BookRepository());
            var books = bookService.GetPublisherBooksInfo();
            bool isOK = false;
            foreach (var book in books.PublishBooks)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Id}. {book.Book.Name}, {book.Publisher.Name}, {book.Book.PageCount}, {book.Book.StockCount}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void AddPurchase(ref PurchaseAdd purchase)
        {
            PurchaseService purchaseService = new PurchaseService(new PurchaseRepository());
            BookService bookService = new BookService(new BookRepository());
            GetBooks();
        SetBookId:
            try
            {
                Console.Write("Choose the book you want to buy: ");
                purchase.BookId = Convert.ToInt32(Console.ReadLine());
                if (purchase.BookId < 0) { Console.WriteLine("Enter again"); goto SetBookId; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto SetBookId;
            }
        SetBookCount:
            try
            {
                Console.Write("Write how much you will buying: ");
                purchase.BookCount = Convert.ToInt32(Console.ReadLine());
                if (purchase.BookCount < 0) { Console.WriteLine("Enter again"); goto SetBookCount; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto SetBookCount;
            }
            var b = bookService.GetById(purchase.BookId);
            if (b.StockCount >= purchase.BookCount)
            {
                b.StockCount -= purchase.BookCount;
                purchase.SoldDate = DateTime.Now;
                Console.WriteLine("The book was bought");
            }
            else if (b.StockCount <= 0 || b.StockCount == null)
            {
                Console.WriteLine("The book is not in stock");
                return;
            }
            else
            {
                Console.WriteLine("There are not as many books as you want");
                return;
            }
            purchaseService.Update(AutoMapperProfile.MapperConfigure<Purchase, PurchaseAdd>(purchase));
            bookService.Update(AutoMapperProfile.MapperConfigure<Book, BookUpdate>(b));
            GetBooks();
        }
        static void GetPurchasesBookInfo()
        {
            PurchaseService purchaseService = new PurchaseService(new PurchaseRepository());
            var books = purchaseService.GetPurchasesBookInfo();
            bool isOK = false;
            foreach (var book in books.Book.BookGenres)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Id}. {book.Book.Name}, {book.Genre.Name}, {book.Book.PageCount}, {book.Book.StockCount}");
                    isOK = true;
                }
            }
            if (!isOK) Console.WriteLine("Database is empty");
        }
        static void SetChoise(ref int choise)
        {
        SetChoise:
            try
            {
                Console.Write("Select: ");
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise < 0) { Console.WriteLine("Enter again"); goto SetChoise; }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
