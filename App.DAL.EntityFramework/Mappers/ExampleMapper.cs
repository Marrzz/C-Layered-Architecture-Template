using AutoMapper;
using Base.DAL;

namespace App.DAL.EntityFramework.Mappers;

public class ExampleMapper : BaseMapper<App.DAL.DTO.Example, App.Domain.Example>
{
    public ExampleMapper(IMapper mapper) : base(mapper)
    {
    }
}