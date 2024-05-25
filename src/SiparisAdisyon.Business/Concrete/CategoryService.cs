using AutoMapper;
using OneOf;
using SiparisAdisyon.Business.Abstract;
using SiparisAdisyon.Business.Dtos.Categories;
using SiparisAdisyon.Core.Results;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Business.Concrete;

public class CategoryService : ICategoryService
{

    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<OneOf<int, Error>> Create(CategoryCreateDto categoryCreateDto)
    {

        int createResult = await _categoryRepository.AddAsync(_mapper.Map<Category>(categoryCreateDto));

        if (createResult == 0)
        {

            return new Error
            {
                Message = "Kategori eklenirken bir hata oluştu",
                Code = "CATEGORYCREATEERROR",
                Success = false
            };

        }

        return createResult;

    }

    public async Task<List<OneOf<CategoryDetailDto, Error>>> GetAll()
    {

        List<Category> categories = await _categoryRepository.GetAllAsync<Category>();

        List<CategoryDetailDto> categoryDetailDtos = _mapper.Map<List<CategoryDetailDto>>(categories);

        if (categoryDetailDtos.Count == 0)
        {
            return new List<OneOf<CategoryDetailDto, Error>>{ new Error
                                                          {   Message = "Kategori bulunamadı",
                                                              Code = "CATEGORYNOTFOUND",
                                                              Success = false }
                                                          };
        }

        return categoryDetailDtos
                                .Select(dto => (OneOf<CategoryDetailDto, Error>)dto)
                                .ToList();

    }

    public async Task<OneOf<CategoryDetailDto, Error>> GetById(int id)
    {

        Category category = await _categoryRepository.FindByIdAsync<Category>(id);
        if (category is null)
        {

            return new Error
            {
                Message = "Kategori bulunamadı",
                Code = "CATEGORYNOTFOUND",
                Success = false
            };

        }

        return _mapper.Map<CategoryDetailDto>(category);

    }

}