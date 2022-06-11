using App.BLL.DTO;
using App.Contracts.BLL.Services;
using App.Contracts.DAL;
using Base.BLL;
using Base.Contracts.Base;

namespace App.BLL.Services;

public class ExampleService : BaseEntityService<App.BLL.DTO.Example, App.DAL.DTO.Example, IExampleRepository>, IExampleService
{
    public ExampleService(IExampleRepository repository, IMapper<Example, DAL.DTO.Example> mapper) : base(repository, mapper)
    {
    }
}