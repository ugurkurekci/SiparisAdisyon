using OneOf;
using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Core.Results;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Repository.Abstract;

public interface IAuthRepository : IBaseRepository<Auth>
{

    Task<OneOf<Result, Error>> LoginAsync(Auth auth);

    Task<OneOf<Result, Error>> RegisterAsync(Auth auth);

    Task<OneOf<Result, Error>> UserExistsAsync(string username);

}