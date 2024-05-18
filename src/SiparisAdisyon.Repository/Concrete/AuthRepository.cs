using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Core.Utility.Common;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Repository.Concrete;

public class AuthRepository : BaseRepository<Auth>, IAuthRepository
{

    public AuthRepository(ProjectDbContext context) : base(context) { }

    public async Task<bool> UserExists(string username)
    {

        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentNullException(nameof(username));
        }

        Auth existUserName = await FindByKeyValueAsync<Auth>(Constans.COLUMN_USERNAME, username);
        return existUserName != null;

    }

}