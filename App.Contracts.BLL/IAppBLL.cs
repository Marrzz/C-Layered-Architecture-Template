using App.Contracts.BLL.Services;
using Base.Contracts.BLL;

namespace App.Contracts.BLL;

public interface IAppBLL : IBLL
{
    //TODO: Services defined in the Services directory go here!
    
    IExampleService Examples {get;}
}