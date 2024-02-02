using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Shared.Dtos;
using System.Text.Json;

namespace MiniShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productManager;

        public ProductsController(IProductService productManager)
        {
            _productManager = productManager;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Create(AddProductDto addProductDto) {
            var response = await _productManager.CreateAsync(addProductDto);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }
    }
}
