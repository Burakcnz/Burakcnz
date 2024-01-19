using Microsoft.AspNetCore.Mvc;

namespace BookApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
