using Microsoft.EntityFrameworkCore;
using WithIn.Application.Common.Interfaces;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class GenericRepository<T>(ApplicationDbContext dbContext) : IGenericRepository<T>
    where T : class
{
    public void Add(T entity)
    {
        dbContext.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        dbContext.Set<T>().Remove(entity);
    }

    public async Task<List<T>> GetAll()
    {
        return await dbContext.Set<T>().ToListAsync();
    }

    public IQueryable<T> GetQueryable()
    {
        return dbContext.Set<T>().AsQueryable();
    }
}
