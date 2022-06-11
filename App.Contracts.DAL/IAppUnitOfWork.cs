namespace App.Contracts.DAL;

public interface IAppUnitOfWork : IUnitOfWork.IUnitOfWork
{
    //TODO: Custom Repositories created in App.DAL.EntityFramework go here!
    
    IExampleRepository Examples {get;}
}