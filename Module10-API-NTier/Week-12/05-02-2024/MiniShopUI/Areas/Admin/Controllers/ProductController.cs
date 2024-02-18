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
        public async Task<List<CategoryViewModel>> GetCategories()
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost:5100/Categories/NonDeleted/false");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
            response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponse);
            return response.Data;
        }
        #endregion
        //Bu action, silinmemiş ürün listesini gösterecek action
        public async Task<IActionResult> Index()
        {
            Response<List<ProductViewModel>> response = new Response<List<ProductViewModel>>();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("http://localhost:5100/Products/GetUnDeletedProducts");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
            response = JsonSerializer.Deserialize<Response<List<ProductViewModel>>>(contentResponse);
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
            var categoryList = await GetCategories();
            AddProductViewModel addProductViewModel = new AddProductViewModel { CategoryList=categoryList };
            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel addProductViewModel)
        {
            addProductViewModel.ImageUrl = "";
            addProductViewModel.Url = MyUrlHelper.GetUrl(addProductViewModel.Name);
            return View();
        }
    }
}


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