using Microsoft.EntityFrameworkCore;
using QueryProviderExample;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                           .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
                           .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                           .EnableSensitiveDataLogging()
                           .Options;

ApplicationDbContext context = new (dbContextOptions);
context.Database.EnsureDeleted();
context.Database.EnsureCreated();


var query = context.Users
                   .Where(x => x.Id > 4 && x.Name != null)
                   .ToList();


//var query = context.Users
//                   .Where(x => x.Id > 4 && true)
//                   .ToList();

//var query = context.Users
//                   .Where(x => x.Id > 4)
//                   .ToList();


    context.Users.Where(x => x.Name == "Mohammad")
                 .OrderBy(x => x.Id)
                 .Take(5)
                 .Select(x => new { x.Id, x.Name });