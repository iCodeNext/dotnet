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
//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();

