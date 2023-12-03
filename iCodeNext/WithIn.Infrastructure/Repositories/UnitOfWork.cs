using WithIn.Application.Common.Interfaces;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}