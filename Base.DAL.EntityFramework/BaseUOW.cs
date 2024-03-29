﻿using Microsoft.EntityFrameworkCore;

namespace Base.DAL;

public class BaseUOW<TDbContext> : IUnitOfWork.IUnitOfWork
    where TDbContext : DbContext
{
    protected readonly TDbContext UOWDbContext;

    public BaseUOW(TDbContext dbContext)
    {
        UOWDbContext = dbContext;
    }

    public virtual async Task<int> SaveChangesAsync()
    {
        return await UOWDbContext.SaveChangesAsync();
    }

    public virtual int SaveChanges()
    {
        return UOWDbContext.SaveChanges();
    }
}
