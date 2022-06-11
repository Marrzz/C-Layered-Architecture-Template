using Base.Contracts.BLL;

namespace Base.BLL;

public abstract class BaseBLL<TDal> : IBLL
{
    
    public abstract Task<int> SaveChangesAsync();

    public abstract int SaveChanges();
    
}