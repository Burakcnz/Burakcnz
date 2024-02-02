using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.EfCore.Contexts;
using MiniShop.Data.Concrete.EfCore.Repositories;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response<CategoryDto>> CreateAsync(AddCategoryDto addCategoryDto)
        {
            Category category = _mapper.Map<Category>(addCategoryDto);
            category.IsDeleted = false;
            category.CreatedDate=DateTime.Now;
            category.ModifiedDate=DateTime.Now;
            Category createdCategory = await _categoryRepository.CreateAsync(category);
            if(createdCategory == null)
            {
                return Response<CategoryDto>.Fail("Bir hata oluştu", 401);
            }
            CategoryDto createdCategoryDto = _mapper.Map<CategoryDto>(createdCategory);
            return Response<CategoryDto>.Success(createdCategoryDto, 200, 1);
        }

        public async Task<Response<List<CategoryDto>>> GetActiveCategoriesAsync(bool isActive = true)
        {
            var categories = await _categoryRepository.GetActiveCategoriesAsync(isActive);
            if (categories.Count == 0)
            {
                return Response<List<CategoryDto>>.Fail("Hiç kategori yok", 404);
            }
            List<CategoryDto> categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return Response<List<CategoryDto>>.Success(categoryDtos, 200,categoryDtos.Count);
        }

        public async Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories.Count == 0)
            {
                return Response<List<CategoryDto>>.Fail("Hiç kategori yok", 404);
            }
            List<CategoryDto> categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return Response<List<CategoryDto>>.Success(categoryDtos, 200, categoryDtos.Count);
        }

        public async Task<Response<List<CategoryDto>>> GetAllNonDeletedAsync(bool isDeleted=false)
        {
            var categories = await _categoryRepository.GetAllNonDeletedAsync(isDeleted);
            if (categories.Count == 0)
            {
                return Response<List<CategoryDto>>.Fail("Hiç silinmemiş kategori yok", 404);
            }
            List<CategoryDto> categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return Response<List<CategoryDto>>.Success(categoryDtos, 200, categoryDtos.Count);
        }

        public async Task<Response<CategoryDto>> GetByIdAsync(int id)
        {
            Category category = await _categoryRepository.GetByIdAsync(id);
            if(category == null)
            {
                return Response<CategoryDto>.Fail("Böyle bir kategori bulunamadı", 404);
            }
            CategoryDto categoryDto = _mapper.Map<CategoryDto>(category);
            return Response<CategoryDto>.Success(categoryDto, 200,1);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            Category category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<NoContent>.Fail("Böyle bir kategori bulunamadı", 404);
            }
            await _categoryRepository.Delete(category);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            Category category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<NoContent>.Fail("Böyle bir kategori bulunamadı", 404);
            }
            category.IsDeleted = !category.IsDeleted;
            category.IsActive = false;
            category.ModifiedDate = DateTime.Now;
            await _categoryRepository.UpdateAsync(category);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<CategoryDto>> UpdateAsync(EditCategoryDto editCategoryDto)
        {
            Category category = _mapper.Map<Category>(editCategoryDto);
            if (category == null)
            {
                return Response<CategoryDto>.Fail("Bir sorun oluştu", 400);
            }
            category.ModifiedDate = DateTime.Now;
            await _categoryRepository.UpdateAsync(category);
            CategoryDto categoryDto = _mapper.Map<CategoryDto>(category);
            return Response<CategoryDto>.Success(categoryDto, 200, 1);
        }

        public async Task<Response<NoContent>> UpdateIsActiveAsync(int id)
        {
            Category category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<NoContent>.Fail("Böyle bir kategori bulunamadı", 404);
            }
            category.IsActive = !category.IsActive;
            category.ModifiedDate = DateTime.Now;
            await _categoryRepository.UpdateAsync(category);
            return Response<NoContent>.Success(200);
        }
    }
}



//CategoryDto categoryDto = new CategoryDto
//{
//    Id= category.Id,
//    Name= category.Name,
//    Description= category.Description,
//    Url= category.Url
//};