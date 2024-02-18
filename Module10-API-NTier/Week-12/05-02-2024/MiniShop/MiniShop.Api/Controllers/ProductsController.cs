using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Shared.Dtos;
using System.Text.Json;

namespace MiniShop.Api.Controllers
{
    [Route("[controller]")]
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

        [HttpGet("GetDeletedProducts/{isActive?}")]
        public async Task<IActionResult> GetDeleted(bool? isActive)
        {
            var response = await _productManager.GetDeletedAndActiveProductsAsync(true,isActive);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("GetUnDeletedProducts/{isActive?}")]
        public async Task<IActionResult> GetUnDeleted(bool? isActive=null)
        {
            var response = await _productManager.GetDeletedAndActiveProductsAsync(false, isActive);

            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productManager.GetByIdAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("WithCategories/{id}")]
        public async Task<IActionResult> GetProductWithCategories(int id)
        {
            var response = await _productManager.GetProductWithCategoriesAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productManager.GetAllAsync();
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("HomePageProducts")]
        public async Task<IActionResult> GetHomePageProducts()
        {
            var response = await _productManager.GetHomePageProductsAsync();
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("ByCategoryId/{id}")]
        public async Task<IActionResult> GetProductsByCategoryId(int id)
        {
            var response = await _productManager.GetProductsByCategoryIdAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _productManager.HardDeleteAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("Trash/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _productManager.SoftDeleteAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EditProductDto editProductDto)
        {
            var response = await _productManager.UpdateAsync(editProductDto);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        //[HttpPost("UpdateIsActive/{id}")]
        [HttpGet("UpdateIsActive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _productManager.UpdateIsActiveAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        //[HttpPost("UpdateIsHome/{id}")]
        [HttpGet("UpdateIsHome/{id}")]
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var response = await _productManager.UpdateIsHomeAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("Count")]
        public async Task<IActionResult> Count()
        {
            var response = await _productManager.GetProductsCountAsync();
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("ActiveCount")]
        public async Task<IActionResult> ActiveCount()
        {
            var response = await _productManager.GetActiveProductsCountAsync();
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }
    }
}
