using Microsoft.EntityFrameworkCore;

namespace QueryProviderExample;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
