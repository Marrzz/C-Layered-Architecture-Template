using Base.Contracts.DAL;

namespace App.Contracts.DAL;

public interface IExampleRepository : IEntityRepository<App.DAL.DTO.Example>,IExampleRepositoryCustom<App.DAL.DTO.Example>
{
    
}

public interface IExampleRepositoryCustom<TEntity> 
{
    // write your custom methods here

}
