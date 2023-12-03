using WithIn.Domain.Entities;

namespace WithIn.Application.Common.Interfaces;
public interface IUnitOfWork
{
    IGenericRepository<User> User { get; }
    IGenericRepository<Order> Order { get; }
    IGenericRepository<OrderItem> OrderItem { get; }
    Task<int> SaveAsync();
}
