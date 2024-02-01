using Microsoft.EntityFrameworkCore;

namespace QueryProviderExample;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Post> Posts { get; set; }
}


public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Code { get; set; }
}

public record GetPostDto(int Id, string Title, string Description);