using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace QueryProviderExample;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}

public class User
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Email { get; set; }
}
