using AddAsyncVsAdd.Domain;
using Microsoft.EntityFrameworkCore;

namespace AddAsyncVsAdd.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
}