using OneOf;
using SiparisAdisyon.Business.Dtos.Auths;
using SiparisAdisyon.Core.Results;

namespace SiparisAdisyon.Business.Abstract;

public interface IAuthService
{
    Task<OneOf<Result, Error>> LoginAsync(LoginDto loginDto);

    Task<OneOf<Result, Error>> RegisterAsync(RegisterDto registerDto);

}