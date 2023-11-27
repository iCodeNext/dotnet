using WithIn.Domain.Entities;

namespace WithIn.Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Task<Order> FindAsync(int id);
    Task<int> SaveAsync();
}
