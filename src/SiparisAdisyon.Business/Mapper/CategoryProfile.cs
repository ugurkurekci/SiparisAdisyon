using AutoMapper;
using SiparisAdisyon.Business.Dtos.Categories;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Business.Mapper;

public class CategoryProfile : Profile
{

    public CategoryProfile()
    {
        CreateMap<Category, CategoryDetailDto>();
        CreateMap<CategoryCreateDto, Category>();
    }

}