using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MiniShopUI.Areas.Admin.Helpers;
using MiniShopUI.Areas.Admin.Models;
using System.Text;
using System.Text.Json;

namespace MiniShopUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        #region NonActions
        [NonAction]
        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost:5100/Categories/NonDeleted/false");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
            response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponse);
            return response.Data;
        }

        [NonAction]
        public async Task<ProductViewModel> GetProductAsync(int id)
        {
            Response<ProductViewModel> response = new Response<ProductViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/WithCategories/{id}");
                string contentResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponse);
            }
            return response.Data;
        }
        #endregion
        
        //Bu action, silinmemiş ürün listesini gösterecek action
        public async Task<IActionResult> Index(bool id=false)
        {
            Response<List<ProductViewModel>> response = new Response<List<ProductViewModel>>();
            HttpClient httpClient = new HttpClient();
            var endPointName = id ? "GetDeletedProducts" : "GetUnDeletedProducts";
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/{endPointName}");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
            response = JsonSerializer.Deserialize<Response<List<ProductViewModel>>>(contentResponse);
            ViewBag.ShowDeleted = id;
            return View(response.Data);
        }

        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/UpdateIsActive/{id}");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateIsHome(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/UpdateIsHome/{id}");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categoryList = await GetCategoriesAsync();
            AddProductViewModel addProductViewModel = new AddProductViewModel { CategoryList = categoryList };
            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel addProductViewModel)
        {
            addProductViewModel.ImageUrl = "";
            if(ModelState.IsValid && addProductViewModel.CategoryIds.Count>0)
            {
                //Aslında önce resim yüklemeyi yapacağız burada.
                addProductViewModel.Url = MyUrlHelper.GetUrl(addProductViewModel.Name);
                var serializeModel = JsonSerializer.Serialize(addProductViewModel);
                StringContent stringContent = new StringContent(serializeModel,Encoding.UTF8,"application/json");
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:5100/Products/Add", stringContent);
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.CategoryErrorMessage = addProductViewModel.CategoryIds.Count == 0 ? "En az bir kategori seçilmeden, ürün kaydı yapılamaz." : null;
            addProductViewModel.CategoryList = await GetCategoriesAsync();
            return View(addProductViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ProductViewModel productViewModel = await GetProductAsync(id);
            EditProductViewModel editProductViewModel = new EditProductViewModel
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                ImageUrl = productViewModel.ImageUrl,
                Url = productViewModel.Url,
                IsActive = productViewModel.IsActive,
                IsHome = productViewModel.IsHome,
                Price = productViewModel.Price,
                Properties = productViewModel.Properties,
                CategoryIds = productViewModel.CategoryList.Select(c => c.Id).ToList(),
                CategoryList= await GetCategoriesAsync(),
            };
            return View(editProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel editProductViewModel)
        {
            editProductViewModel.ImageUrl = "";
            if(ModelState.IsValid && editProductViewModel.CategoryIds.Count > 0)
            {
                editProductViewModel.Url = MyUrlHelper.GetUrl(editProductViewModel.Name);
                var serializeModel = JsonSerializer.Serialize(editProductViewModel);
                StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage httpResponseMessage = await httpClient.PutAsync("http://localhost:5100/Products/Update", stringContent);
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.CategoryErrorMessage = editProductViewModel.CategoryIds.Count == 0 ? "En az bir kategori seçilmeden, ürün kaydı yapılamaz." : null;
            editProductViewModel.CategoryList = await GetCategoriesAsync();
            return View(editProductViewModel);

        }
        
        [HttpGet]    
        public async Task<IActionResult> Delete(int id)
        {
            ProductViewModel productViewModel = await GetProductAsync(id);
            return View(productViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/Delete/{id}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"http://localhost:5100/Products/Trash/{id}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}


//

//public async Task<IActionResult> UpdateIsActive(int id)
//{
//    HttpClient httpClient = new HttpClient();
//    StringContent httpContent = new StringContent("", Encoding.UTF8, "application/json");
//    HttpResponseMessage responseMessage = await httpClient.PostAsync($"http://localhost:5100/Products/UpdateIsActive/{id}", httpContent);
//    return RedirectToAction("Index");
//}

//public async Task<IActionResult> UpdateIsHome(int id)
//{
//    HttpClient httpClient = new HttpClient();
//    StringContent httpContent = new StringContent("", Encoding.UTF8, "application/json");
//    HttpResponseMessage responseMessage = await httpClient.PostAsync($"http://localhost:5100/Products/UpdateIsHome/{id}", httpContent);
//    return RedirectToAction("Index");
//}