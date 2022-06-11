namespace IUnitOfWork;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();

    int SaveChanges();
}