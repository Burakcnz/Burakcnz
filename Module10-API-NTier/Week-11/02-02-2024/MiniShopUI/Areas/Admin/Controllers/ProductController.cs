using Microsoft.AspNetCore.Mvc;
using MiniShopUI.Areas.Admin.Models;
using System.Text.Json;

namespace MiniShopUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
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

        }
    }
}
