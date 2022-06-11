using AutoMapper;
using Base.DAL;

namespace App.DAL.EntityFramework.Mappers.Identity;

public class AppUserMapper : BaseMapper<App.DAL.DTO.Identity.AppUser, App.Domain.Identity.AppUser>
{
    public AppUserMapper(IMapper mapper) : base(mapper)
    {   
    }
}