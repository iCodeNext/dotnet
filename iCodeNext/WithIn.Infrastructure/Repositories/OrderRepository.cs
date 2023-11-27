using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class OrderRepository(ApplicationDbContext dbContext) : IOrderRepository
{
     
    public void Add(Order order)
    {
        dbContext.Order.Add(order);
    }

    public async Task<Order> FindAsync(int id)
    {
       return await dbContext.Order.FindAsync(id);
    }

    public async Task<int> SaveAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}
