using WithIn.Domain.Entities;

namespace WithIn.Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    void Delete(Order order);
    Task<Order> FindAsync(int id);

 }
