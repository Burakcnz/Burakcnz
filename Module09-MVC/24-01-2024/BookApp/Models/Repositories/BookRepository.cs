using BookApp.Areas.Admin.General;
using BookApp.Models.Contexts;
using BookApp.Models.Entities.Concrete;

namespace BookApp.Models.Repositories
{
    public class BookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks(bool? isActive = null, bool? isDeleted = null)
        {
            List<Book> result;
            if (isActive == null)
            {
                if (isDeleted == null)
                {
                    result = _context.Books.ToList();
                }
                else
                {
                    result = _context
                        .Books
                        .Where(b => b.IsDeleted == isDeleted)
                        .ToList();
                }
            }
            else
            {
                if (isDeleted == null)
                {
                    result = _context
                        .Books
                        .Where(b => b.IsActive == isActive)
                        .ToList();
                }
                else
                {
                    result = _context
                        .Books
                        .Where(b => b.IsActive == isActive && b.IsDeleted == isDeleted)
                        .ToList();
                }
            }

            return result;
        }
        public List<Book> GetHomePageBook()
        {
            List<Book> result = _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted && b.IsHome)
                .ToList();
            return result;
        }
        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            // var book = _context.Books.Where(b => b.Id == id).SingleOrDefault();
            var book = _context.Books.Find(id);
            return book;
        }

        public void UpdateBook(Book book)
        {
            var oldBook = GetBookById(book.Id);
            oldBook.Name = book.Name;
            oldBook.Abstract = book.Abstract;
            oldBook.IsHome = book.IsHome;
            oldBook.IsDeleted = book.IsDeleted;
            oldBook.IsActive = book.IsActive;
            oldBook.Price = book.Price;
            oldBook.ImageUrl = book.ImageUrl;
            oldBook.Url = Jobs.GetUrl(book.Name);
            oldBook.ModifiedDate = DateTime.Now;
            oldBook.PageCount = book.PageCount;
            oldBook.Stock = book.Stock;
            _context.Books.Update(oldBook);
            _context.SaveChanges();
        }


        public void HardDelete(int id)
        {
            var book=GetBookById(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void SoftDelete(int id)
        {
            var book = GetBookById(id);
            book.IsDeleted = !book.IsDeleted;
            book.ModifiedDate = DateTime.Now;
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
