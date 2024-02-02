using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Mapping
{
    public class GeneralMappingProfile:Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<Category, EditCategoryDto>().ReverseMap();

            CreateMap<Product, ProductDto>()
                .ForMember(pdto => pdto.CategoryList, options =>
                    options.MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
                .ReverseMap();

            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Product, EditProductDto>().ReverseMap();
        }
    }
}
