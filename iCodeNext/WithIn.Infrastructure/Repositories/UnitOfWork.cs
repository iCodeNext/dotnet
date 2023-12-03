using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IGenericRepository<User> User
        => new GenericRepository<User>(_dbContext);

    public IGenericRepository<Order> Order
        => new GenericRepository<Order>(_dbContext);

    public IGenericRepository<OrderItem> OrderItem
        => new GenericRepository<OrderItem>(_dbContext);

    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}
