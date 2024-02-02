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

        public Task<Response<CategoryDto>> CreateAsync(AddCategoryDto addCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDto>>> GetAllNonDeletedAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Response<CategoryDto>> GetByIdAsync(int id)
        {
            Category category = await _categoryRepository.GetByIdAsync(id);
            if(category == null)
            {
                return Response<CategoryDto>.Fail("Böyle bir kategori bulunamadı", 404);
            }
            CategoryDto categoryDto = _mapper.Map<CategoryDto>(category);
            return Response<CategoryDto>.Success(categoryDto, 200);
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CategoryDto>> UpdateAsync(EditCategoryDto editCategoryDto)
        {
            throw new NotImplementedException();
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