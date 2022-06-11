using AutoMapper;

namespace App.DAL.EntityFramework;

public class AutoMapperCfg : Profile
{
    //TODO: Add mapping configurations DAL -> Domain
    public AutoMapperCfg()
    {

        CreateMap<App.DAL.DTO.Example, App.Domain.Example>().ReverseMap();
        CreateMap<App.DAL.DTO.Identity.AppUser, App.Domain.Identity.AppRole>().ReverseMap();

    }
   
}