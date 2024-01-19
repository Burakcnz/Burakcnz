using BookApp.Models;
using BookApp.Models.Contexts;
using BookApp.Models.Entities.Concrete;
using BookApp.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookRepository _repository;
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
            _repository = new BookRepository(_context);
        }

        public IActionResult Index()
        {
            List<Book> result = _repository.GetHomePageProducts();
            return View(result);
        }

    }
}
