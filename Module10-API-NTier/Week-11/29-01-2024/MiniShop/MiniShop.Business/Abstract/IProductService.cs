using MiniShop.Shared.Dtos;
using MiniShop.Shared.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        Task<Response<ProductDto>> GetByIdAsync(int id);
        Task<Response<List<ProductDto>>> GetAllAsync();
        Task<Response<List<ProductDto>>> GetAllNonDeletedAsync(bool isDeleted=false);
        Task<Response<ProductDto>> CreateAsync(AddProductDto addProductDto);
        Task<Response<ProductDto>> UpdateAsync(EditProductDto editProductDto);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        Task<Response<List<ProductDto>>> GetHomePageProductsAsync();
        Task<Response<List<ProductDto>>> GetActiveProductsAsync(bool isActive=true);
        Task<Response<List<ProductDto>>> GetProductsByCategoryIdAsync(int categoryId, bool? isActive=true);
        Task<Response<ProductDto>> GetProductWithCategoriesAsync(int id, bool? isActive=true);

    }
}
