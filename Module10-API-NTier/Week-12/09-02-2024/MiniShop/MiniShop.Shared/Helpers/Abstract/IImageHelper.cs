using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<string> ImageUpload(IFormFile image, string folderName = null);
        bool ImageIsValid(string fileType);
    }
}
