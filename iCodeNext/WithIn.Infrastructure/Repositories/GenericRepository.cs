using Microsoft.EntityFrameworkCore;
using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;
public class GenericRepository<TEntity>(ApplicationDbContext dbContext) 
    : IGenericRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void Add(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
    }

    public async Task<TEntity> Get(int id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Attach(entity);
        _dbContext.Set<TEntity>().Entry(entity).State = EntityState.Modified;
    }
}
