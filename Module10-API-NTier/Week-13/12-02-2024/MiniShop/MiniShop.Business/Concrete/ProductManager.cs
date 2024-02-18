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
            return Response<ProductDto>.Success(productDto,200, 1);
        }

        public async Task<Response<List<ProductDto>>> GetDeletedAndActiveProductsAsync(bool isDeleted=false, bool? isActive = true)
        {
            var products = await _productRepository.GetDeletedAndActiveProductsAsync(isDeleted, isActive);
            if(products.Count==0)
            {
                return Response<List<ProductDto>>.Fail("Hiç ürün bilgisi bulunamadı", 404);
            }
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Response<List<ProductDto>>.Success(productDtos,200, productDtos.Count); 
        }

        public async Task<Response<List<ProductDto>>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            if (products.Count == 0)
            {
                return Response<List<ProductDto>>.Fail("Hiç ürün bilgisi bulunamadı", 404);
            }
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Response<List<ProductDto>>.Success(productDtos, 200, productDtos.Count);
        }

        public async Task<Response<ProductDto>> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if(product == null)
            {
                return Response<ProductDto>.Fail("Böyle bir ürün bilgisi bulunamadı", 404);
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return Response<ProductDto>.Success(productDto, 200, 1);
        }

        public async Task<Response<List<ProductDto>>> GetHomePageProductsAsync()
        {
            var products = await _productRepository.GetHomePageProductsAsync();
            if (products.Count == 0)
            {
                return Response<List<ProductDto>>.Fail("Hiç ana sayfa ürünü bilgisi bulunamadı", 404);
            }
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Response<List<ProductDto>>.Success(productDtos, 200, productDtos.Count);
        }

        public async Task<Response<List<ProductDto>>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId);
            if (products.Count == 0)
            {
                return Response<List<ProductDto>>.Fail("Hiç ürün bilgisi bulunamadı", 404);
            }
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Response<List<ProductDto>>.Success(productDtos, 200, productDtos.Count);
        }

        public async Task<Response<ProductDto>> GetProductWithCategoriesAsync(int id)
        {
            var product = await _productRepository.GetProductWithCategoriesAsync(id);
            if (product==null)
            {
                return Response<ProductDto>.Fail("Hiç ürün bilgisi bulunamadı", 404);
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return Response<ProductDto>.Success(productDto, 200, 1);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if(product==null)
            {
                return Response<NoContent>.Fail("Böyle bir ürün bilgisi bulunamadı", 401);
            }
            await _productRepository.Delete(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("Böyle bir ürün bilgisi bulunamadı", 401);
            }
            product.IsDeleted=!product.IsDeleted;
            product.IsActive = false;
            product.ModifiedDate = DateTime.Now;
            await _productRepository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<ProductDto>> UpdateAsync(EditProductDto editProductDto)
        {
            var editProduct = _mapper.Map<Product>(editProductDto);
            if (editProduct == null)
            {
                return Response<ProductDto>.Fail("Böyle bir ürün bilgisi bulunamadı", 401);
            }
            editProduct.ModifiedDate = DateTime.Now;
            await _productRepository.UpdateAsync(editProduct);
            await _productRepository.ClearProductCategory(editProduct.Id);
            editProduct.ProductCategories = editProductDto
                .CategoryIds
                .Select(catId => new ProductCategory
                {
                    ProductId = editProduct.Id,
                    CategoryId = catId
                }).ToList();
            await _productRepository.UpdateAsync(editProduct);
            
            return Response<ProductDto>.Success(200);

        }

        public async Task<Response<NoContent>> UpdateIsActiveAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("Böyle bir ürün bilgisi bulunamadı", 401);
            }
            product.IsActive = !product.IsActive;
            product.ModifiedDate=DateTime.Now;
            await _productRepository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> UpdateIsHomeAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("Böyle bir ürün bilgisi bulunamadı", 401);
            }
            product.IsHome = !product.IsHome;
            product.ModifiedDate = DateTime.Now;
            await _productRepository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<int>> GetProductsCountAsync()
        {
            var result = await _productRepository.CountAsync(p=>!p.IsDeleted);
            return Response<int>.Success(result,200);
        }

        public async Task<Response<int>> GetActiveProductsCountAsync()
        {
            var result = await _productRepository.CountAsync(p => !p.IsDeleted && p.IsActive);
            return Response<int>.Success(result, 200);
        }
    }
}
