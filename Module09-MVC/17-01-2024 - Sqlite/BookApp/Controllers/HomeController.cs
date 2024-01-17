using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
