using OneOf;
using SiparisAdisyon.Business.Dtos.Categories;
using SiparisAdisyon.Core.Results;

namespace SiparisAdisyon.Business.Abstract;

public interface ICategoryService
{

    Task<OneOf<int, Error>> Create(CategoryCreateDto categoryCreateDto);

    Task<OneOf<CategoryDetailDto, Error>> GetById(int id);

    Task<List<OneOf<CategoryDetailDto, Error>>> GetAll();

}