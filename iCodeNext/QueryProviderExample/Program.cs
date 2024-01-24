using Microsoft.EntityFrameworkCore;
using QueryProviderExample;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                           .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
                           .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                           .EnableSensitiveDataLogging()
                           .Options;

ApplicationDbContext context = new(dbContextOptions);
//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();


//var ticketA = context.Tickets.Single(e => e.Id == 1);
//var TicketB = new Ticket { Id = 1, Title = "iCodeNext" };

//try
//{
//    context.Update(TicketB); // This will throw
//}
//catch (Exception e)
//{
//    Console.WriteLine($"{e.GetType().FullName}: {e.Message}");
//}

//var ticketA = context.Tickets.AsNoTracking().Single(e => e.Id == 1);
//var TicketB = new Ticket { Id = 1, Title = "iCodeNext" };

//try
//{
//    context.Update(TicketB); // This will throw
//}
//catch (Exception e)
//{
//    Console.WriteLine($"{e.GetType().FullName}: {e.Message}");
//}

var ticketA = context.Tickets
    .Include(x => x.TicketDetails)
    .AsNoTrackingWithIdentityResolution()
    .SelectMany(g => g.TicketDetails, (parent, child) => parent)
    .ToList();

Console.WriteLine("");




























#region Seed
//context.Tickets.Add(new Ticket() { State = TicketState.Added, Title = "Ticket_1" });

//context.SaveChanges();

//context.TicketDetails.Add(new TicketDetails() { TicketId = 1, Title = "Detail_Ticket_1" });

//context.TicketDetails.Add(new TicketDetails() { TicketId = 1, Title = "Detail_Ticket_1" });
//context.SaveChanges();
#endregion