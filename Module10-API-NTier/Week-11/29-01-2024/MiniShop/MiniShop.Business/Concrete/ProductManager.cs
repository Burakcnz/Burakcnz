using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.Dtos;
using MiniShop.Shared.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductManager(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<Response<ProductDto>> CreateAsync(AddProductDto addProductDto)
        {
            var product = _mapper.Map<Product>(addProductDto);
            product.IsDeleted = false;
            product.CreatedDate= DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            var createdProduct = await _productRepository.CreateAsync(product);
            if (createdProduct == null)
            {
                return Response<ProductDto>.Fail("Bir hata oluştu", 400);
            }
            createdProduct.ProductCategories = addProductDto
                .CategoryIds
                .Select(catId => new ProductCategory
                {
                    ProductId = createdProduct.Id,
                    CategoryId = catId
                }).ToList();
            await _productRepository.UpdateAsync(createdProduct);
            var result = await _productRepository.GetProductWithCategoriesAsync(createdProduct.Id);
            var productDto = _mapper.Map<ProductDto>(result);
            return Response<ProductDto>.Success(productDto,200);
        }

        public Task<Response<List<ProductDto>>> GetActiveProductsAsync(bool isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDto>>> GetAllNonDeletedAsync(bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDto>>> GetHomePageProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDto>>> GetProductsByCategoryIdAsync(int categoryId, bool? isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductDto>> GetProductWithCategoriesAsync(int id, bool? isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductDto>> UpdateAsync(EditProductDto editProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
