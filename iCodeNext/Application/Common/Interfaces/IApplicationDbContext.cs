using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<User> User { get; }
    public DbSet<Order> Order { get; }
    public DbSet<OrderItem> OrderItem { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
