using AutoMapper;

namespace App.BLL;

public class AutomapperConfig : Profile
{
    public AutomapperConfig()
    {
        
        //TODO: Add BLL -> DAL Mapping configurations
        CreateMap<App.BLL.DTO.Example, App.DAL.DTO.Example>().ReverseMap();
        CreateMap<App.BLL.DTO.Identity.AppUser, App.DAL.DTO.Identity.AppUser>().ReverseMap();

    }
}
