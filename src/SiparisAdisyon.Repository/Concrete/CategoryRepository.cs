using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Repository.Concrete;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{

    public CategoryRepository(ProjectDbContext context) : base(context) { }

}