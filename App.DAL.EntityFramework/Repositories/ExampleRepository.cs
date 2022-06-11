using App.Contracts.DAL;
using App.DAL.DTO;
using Base.Contracts.Base;
using Base.DAL;

namespace App.DAL.EntityFramework.Repositories;

public class ExampleRepository : BaseEntityRepository<App.DAL.DTO.Example, App.Domain.Example, AppDbContext>, IExampleRepository
{
    public ExampleRepository(AppDbContext dbContext, IMapper<Example, Domain.Example> mapper) : base(dbContext, mapper)
    {
    }
}