using AutoMapper;
using OneOf;
using SiparisAdisyon.Business.Abstract;
using SiparisAdisyon.Business.Dtos;
using SiparisAdisyon.Core.Results;
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
        return await _authRepository.LoginAsync(auth);
    }

    public async Task<OneOf<Result, Error>> RegisterAsync(RegisterDto registerDto)
    {
        Auth auth = _mapper.Map<Auth>(registerDto);
        return await _authRepository.RegisterAsync(auth);
    }
}