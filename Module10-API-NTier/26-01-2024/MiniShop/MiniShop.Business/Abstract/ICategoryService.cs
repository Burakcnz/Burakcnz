using MiniShop.Shared.Dtos;
using MiniShop.Shared.ResponseDtos;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        Task<Response<CategoryDto>> GetByIdAsync(int id);
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<List<CategoryDto>>> GetAllNonDeletedAsync();
        Task<Response<CategoryDto>> CreateAsync(AddCategoryDto addCategoryDto);
        Task<Response<CategoryDto>> UpdateAsync(EditCategoryDto editCategoryDto);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);



    }
}
