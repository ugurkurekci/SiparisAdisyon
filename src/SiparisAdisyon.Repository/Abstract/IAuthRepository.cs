using OneOf;
using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Core.Results;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Repository.Abstract;

public interface IAuthRepository : IBaseRepository<Auth>
{

    Task<bool> UserExists(string username);

}