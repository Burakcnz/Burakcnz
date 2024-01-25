using BookApp.Areas.Admin.General;
using BookApp.Models.Contexts;
using BookApp.Models.Entities.Concrete;
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
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Url = Jobs.GetUrl(book.Name);
                _repository.CreateBook(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var book=_repository.GetBookById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateBook(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book=_repository.GetBookById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult HardDelete(int id)
        {
            _repository.HardDelete(id);
            return RedirectToAction("Index");
        }


        public IActionResult SoftDelete(int id)
        {
            _repository.SoftDelete(id);
            return RedirectToAction("Index");
        }
    }
}
