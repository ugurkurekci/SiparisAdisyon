using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Repository.Concrete;

public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(ProjectDbContext context) : base(context) { }
}