using App.BLL.Mappers;
using App.BLL.Services;
using App.Contracts.BLL;
using App.Contracts.BLL.Services;
using App.Contracts.DAL;
using AutoMapper;
using Base.BLL;

namespace App.BLL;


public class AppBLL : BaseBLL<IAppUnitOfWork>, IAppBLL
{
    protected IAppUnitOfWork UnitOfWork;
    private readonly AutoMapper.IMapper _mapper;

    public AppBLL(IAppUnitOfWork unitOfWork, IMapper mapper)
    {
        UnitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public override async Task<int> SaveChangesAsync()
    {
        return await UnitOfWork.SaveChangesAsync();
    }

    public override int SaveChanges()
    {
        return UnitOfWork.SaveChanges();
    }
    
    
    //TODO: Custom Services here 
    
    private IExampleService? _examples;
    
    public IExampleService Examples =>
        _examples ??= new ExampleService(UnitOfWork.Examples, new ExampleMapper(_mapper));
    
}
