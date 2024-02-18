using ImageUploadApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImageUploadApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _imagesFolder;

        public HomeController(IWebHostEnvironment environment)
        {
            _imagesFolder = Path.Combine(environment.WebRootPath, "images");
            //_imagesFolder => c:/siteler/mysite/wwwroot/images


        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ImageUpload(IFormFile image)
        {
            if (image == null) return null;
            string fileExtension = Path.GetExtension(image.FileName);
            string fileName = $"{Guid.NewGuid()}{fileExtension}";
            string fullPath = Path.Combine(_imagesFolder, fileName);
            await using (var stream = new FileStream(fullPath,FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return View("ImageUpload",fileName);
        }
    }
}
