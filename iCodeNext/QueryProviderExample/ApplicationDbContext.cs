using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace QueryProviderExample;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketDetails> TicketDetails { get; set; }
}
 
public class Ticket
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public TicketState State { get; set; }

    public ICollection<TicketDetails> TicketDetails { get; set; }
}

public class TicketDetails
{
    public int Id { get; set; }
   
    public string Title { get; set; }

    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
}

public enum TicketState
{
    Added,
    InProgress,
    Finish
}