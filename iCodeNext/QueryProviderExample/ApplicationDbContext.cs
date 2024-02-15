using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryProviderExample;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Auther> Authors { get; set; }
}

public class Post
{
    public int Id { get; set; }

    [MaxLength(10)]
    public string Title { get; set; }
    public string Description { get; set; }

    [ForeignKey(nameof(AutherId))]
    public Auther Auther { get; set; }
    public int AutherId { get; set; }
}

public class Auther
{
    public int Id { get; set; }

    [MaxLength(10)]
    public string Name { get; set; }
}