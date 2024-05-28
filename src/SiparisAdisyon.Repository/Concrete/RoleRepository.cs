using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Repository.Concrete;

public class RoleRepository : BaseRepository<Role>, IRoleRepository
{

    public RoleRepository(ProjectDbContext context) : base(context) { }

}