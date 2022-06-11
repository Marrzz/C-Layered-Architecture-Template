using App.Contracts.DAL;
using Base.Contracts.BLL;

namespace App.Contracts.BLL.Services;

public interface IExampleService : IEntityService<App.BLL.DTO.Example>, IExampleRepositoryCustom<App.BLL.DTO.Example>
{
    
}