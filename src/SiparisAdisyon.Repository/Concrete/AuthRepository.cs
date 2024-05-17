using OneOf;
using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Core.Results;
using SiparisAdisyon.Core.Utility.Common;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Entity.Models;
using SiparisAdisyon.Repository.Abstract;

namespace SiparisAdisyon.Repository.Concrete;

public class AuthRepository : BaseRepository<Auth>, IAuthRepository
{

    public AuthRepository(ProjectDbContext context) : base(context) { }

    public async Task<OneOf<Result, Error>> LoginAsync(Auth auth)
    {

        OneOf<Auth, Error> existUserName = await FindByKeyValueAsync<Auth>(Constans.COLUMN_USERNAME, auth.Username);

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

    public async Task<OneOf<Result, Error>> RegisterAsync(Auth auth)
    {

        if (await UserExists(auth.Username))
        {
            return new Error { Message = Constans.ErrorUserExists, Code = Constans.ErrorLoginCode, Success = false };
        }

        byte[] passwordHash, passwordSalt;
        CreatePasswordHash(auth.Password, out passwordHash, out passwordSalt);

        auth.PasswordHash = passwordHash;
        auth.PasswordSalt = passwordSalt;
        auth.Password = "********";

        var addResult = await AddAsync(auth);

        if (addResult.IsT1)
        {
            return new Error { Message = Constans.ErrorAddUser, Code = Constans.ErrorRegisterCode, Success = false };
        }

        return new Result { Message = Constans.SuccessAddUser, Code = Constans.SuccessRegisterCode, Success = true };

    }

    public async Task<bool> UserExists(string username)
    {

        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentNullException(nameof(username));
        }

        OneOf<Auth, Error> existUserName = await FindByKeyValueAsync<Auth>(Constans.COLUMN_USERNAME, username);

        if (existUserName.IsT1)
        {
            return false;
        }

        return true;

    }

    public async Task<OneOf<Result, Error>> UserExistsAsync(string username)
    {

        OneOf<Auth, Error> existUserName = await FindByKeyValueAsync<Auth>(Constans.COLUMN_USERNAME, username);

        if (existUserName.IsT1)
        {
            return new Result { Message = Constans.ErrorUserExists, Code = Constans.ErrorUserExistsCode, Success = true };
        }

        return new Error { Message = Constans.ErrorUserNotFound, Code = Constans.USER_NOT_FOUND, Success = false };

    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {

        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

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

}