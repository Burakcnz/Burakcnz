using BookApp.Models.Contexts;
using BookApp.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly BookRepository _repository;
        public BookController(AppDbContext context)
        {
            _repository = new BookRepository(context);
        }
        public IActionResult Index()
        {
            var books = _repository.GetAllBooks(null, false);
            return View(books);
        }
    }
}
