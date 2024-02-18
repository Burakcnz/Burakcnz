using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MiniShop.Shared.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private string _imagesFolder;
        public ImageHelper(IWebHostEnvironment env)
        {
            _imagesFolder = Path.Combine(env.WebRootPath, "images");
        }
        public bool ImageIsValid(string fileType)
        {
            string[] validExtensions = { ".png", ".jpg", ".jpeg" };
            if(validExtensions.Contains(fileType))
            {
                return true;
            }
            return false;
        }

        public async Task<string> ImageUpload(IFormFile image, string folderName = null)
        {
            if (image == null) return null;
            
            var fileType = Path.GetExtension(image.FileName);
            if (!ImageIsValid(fileType)) return "";
            if(folderName != null)
            {
                _imagesFolder = Path.Combine(_imagesFolder, folderName);
            }
            if(!Directory.Exists(_imagesFolder))
            {
                Directory.CreateDirectory(_imagesFolder);
            }
            var fileName = $"{Guid.NewGuid()}{fileType}";
            var fullPath = Path.Combine(_imagesFolder, fileName);
            await using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            };
            return fileName;
        }
    }
}
