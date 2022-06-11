using AutoMapper;
using Base.DAL;

namespace App.BLL.Mappers;

public class ExampleMapper : BaseMapper<App.BLL.DTO.Example, App.DAL.DTO.Example>
{
    public ExampleMapper(IMapper mapper) : base(mapper)
    {
    }
}