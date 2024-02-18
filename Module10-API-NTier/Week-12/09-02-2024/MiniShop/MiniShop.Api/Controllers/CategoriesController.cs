using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.Dtos;
using System.Text.Json;

namespace MiniShop.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        //localhost:5500/Categories/category/4
        [HttpGet("category/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        //localhost:5500/Categories/GetAll
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllAsync();
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("NonDeleted/{isDeleted?}")]
        public async Task<IActionResult> GetNonDeleted(bool isDeleted = false)
        {
            var response = await _categoryManager.GetAllNonDeletedAsync(isDeleted);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Create(AddCategoryDto addCategoryDto)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDto);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpPut("Update")]//Güncelleme işlemleri için kullanılan Http Metot türü
        public async Task<IActionResult> Edit(EditCategoryDto editCategoryDto)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDto);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpDelete("Delete/{id}")]//Silme işlemleri için kullanılan Http Metot türü
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpDelete("Trash/{id}")]//Silme işlemleri için kullanılan Http Metot türü
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpGet("Actives/{isActive?}")]
        public async Task<IActionResult> GetActiveCategories(bool isActive = true)
        {
            var response = await _categoryManager.GetActiveCategoriesAsync(isActive);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }

        [HttpPut("UpdateIsActive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _categoryManager.UpdateIsActiveAsync(id);
            var responseJsonResult = JsonSerializer.Serialize(response);
            return Ok(responseJsonResult);
        }
    }
}
