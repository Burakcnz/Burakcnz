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
                    result = _context.Books.Where(b => b.IsDeleted == isDeleted).ToList();
                }
            }
            else
            {
                if (isDeleted == null)
                {
                    result = _context.Books.Where(b => b.IsActive == isActive).ToList();
                }
                else
                {
                    result = _context.Books.Where(b => b.IsActive == isActive && b.IsDeleted == isDeleted).ToList();
                }
            }


            return result;

        }
        public List<Book> GetHomePageProducts()
        {
            List<Book> result=_context.Books.Where(b=>b.IsActive && !b.IsDeleted && b.IsHome).ToList();
            return result;
        }
    }
}
