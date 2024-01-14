using AutoMapper;
using Dtos.Layer.CategoryDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class CategoryMapping:Profile
{
    public CategoryMapping()
    {
        CreateMap<Category,ResultCategoryDto>().ReverseMap();
        CreateMap<Category,UpdateCategoryDto>().ReverseMap();
        CreateMap<Category,CreateCategoryDto>().ReverseMap();
        CreateMap<Category,GetCategoryDto>().ReverseMap();
    }
}