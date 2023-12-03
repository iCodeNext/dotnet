using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class OrderRepository(ApplicationDbContext dbContext) 
    : GenericRepository<Order>(dbContext), IOrderRepository
{
    public async Task<Order> FindAsync(int id)
    {
       return await _dbContext.Order.FindAsync(id);
    }
}
