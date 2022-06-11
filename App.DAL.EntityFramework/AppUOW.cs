using App.Contracts.DAL;
using App.DAL.EntityFramework.Mappers;
using App.DAL.EntityFramework.Repositories;
using Base.DAL;

namespace App.DAL.EntityFramework;

public class AppUOW  : BaseUOW<AppDbContext>, IAppUnitOfWork
{
    private readonly AutoMapper.IMapper _mapper;
    public AppUOW(AppDbContext dbContext, AutoMapper.IMapper mapper ) : base(dbContext)
    {
        _mapper = mapper;
    }
    
    //TODO: Add Repositories 
    
    private IExampleRepository? _examples;
    
    public virtual IExampleRepository Examples =>
        _examples ??= new ExampleRepository(UOWDbContext, new ExampleMapper(_mapper));
    

}