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
        [HttpGet]
        public IActionResult Index()
        {
            var books = _repository.GetAllBooks(null, false);
            return View(books);
        }
        //Bu metodun amacı, yeni kitap oluşturma sayfasını açmaktır.
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string sample)
        {
            return View();
        }
    }
}
