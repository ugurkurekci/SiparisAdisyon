using AutoMapper;
using SiparisAdisyon.Business.Dtos;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Business.Mapper;

public class AuthProfile : Profile
{

    public AuthProfile()
    {
        CreateMap<LoginDto, Auth>();
        CreateMap<RegisterDto, Auth>();
    }

}