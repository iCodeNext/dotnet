using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using QueryProviderExample;
using System.Globalization;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                           .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
                           .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                           .EnableSensitiveDataLogging()
                           .Options;

ApplicationDbContext context = new(dbContextOptions);
context.Database.EnsureDeleted();
context.Database.EnsureCreated();


await context.Posts.Where(x => x.Id == 1)
                   .Select(x => new GetPostDto(x.Id, x.Title, x.Description))
                   .FirstOrDefaultAsync(x => x.Id == 1);
 
await context.Posts.Select(x => new GetPostDto(x.Id, x.Title,"")).FirstOrDefaultAsync(x => x.Id == 1);