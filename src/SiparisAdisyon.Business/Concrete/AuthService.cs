using AutoMapper;
using OneOf;
using SiparisAdisyon.Business.Abstract;
using SiparisAdisyon.Business.Dtos;
using SiparisAdisyon.Core.Results;
using SiparisAdisyon.Core.Utility.Common;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Business.Concrete;

public class AuthService : IAuthService
{

    private readonly IAuthRepository _authRepository;
    private readonly IMapper _mapper;

    public AuthService(IAuthRepository authRepository, IMapper mapper)
    {
        _authRepository = authRepository;
        _mapper = mapper;
    }

    public async Task<OneOf<Result, Error>> LoginAsync(LoginDto loginDto)
    {

        Auth auth = _mapper.Map<Auth>(loginDto);

        OneOf<Auth, Error> existUserName = await _authRepository.FindByKeyValueAsync<Auth>(Constans.COLUMN_USERNAME, auth.Username);
        if (existUserName.IsT1)
        {
            return new Error { Message = Constans.ErrorLoginMessage, Code = Constans.ErrorLoginCode, Success = false };
        }

        Auth user = existUserName.AsT0;

        if (!VerifyPasswordHash(auth.Password, user.PasswordHash, user.PasswordSalt))
        {
            return new Error { Message = Constans.ErrorLoginMessage, Code = Constans.ErrorLoginCode, Success = false };
        }

        return new Result { Message = Constans.SuccessLoginMessage, Code = Constans.SuccessLoginCode, Success = true };

    }

    public async Task<OneOf<Result, Error>> RegisterAsync(RegisterDto registerDto)
    {
        Auth auth = _mapper.Map<Auth>(registerDto);

        if (await _authRepository.UserExists(auth.Username))
        {
            return new Error { Message = Constans.ErrorUserExists, Code = Constans.ErrorLoginCode, Success = false };
        }

        byte[] passwordHash, passwordSalt;
        CreatePasswordHash(auth.Password, out passwordHash, out passwordSalt);

        auth.PasswordHash = passwordHash;
        auth.PasswordSalt = passwordSalt;
        auth.Password = "********";

        int addResult = await _authRepository.AddAsync(auth);

        if (addResult == 0)
        {
            return new Error { Message = Constans.ErrorAddUser, Code = Constans.ErrorRegisterCode, Success = false };
        }

        return new Result { Message = Constans.SuccessAddUser, Code = Constans.SuccessRegisterCode, Success = true };
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {

        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passwordHash[i])
                {
                    return false;
                }
            }
        }

        return true;

    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {

        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

    }

}