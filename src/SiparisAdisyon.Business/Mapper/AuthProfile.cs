using AutoMapper;
using SiparisAdisyon.Business.Dtos.Auths;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Business.Mapper;

public class AuthProfile : Profile
{

    public AuthProfile()
    {
        CreateMap<LoginDto, Auth>();
        CreateMap<RegisterDto, Auth>();

        CreateMap<Auth, PersonalDetailDto>();


    }

}