using AddAsyncVsAdd.Context;
using AddAsyncVsAdd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System.Linq.Expressions;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
    .EnableSensitiveDataLogging()
    .Options;

ApplicationDbContext dbContext = new(dbContextOptions);
await dbContext.Database.EnsureDeletedAsync();
await dbContext.Database.EnsureCreatedAsync();

await dbContext.SaveChangesAsync();

dbContext.Customers.Where(x => x.FirstName == "").ToList();


Func<int, bool> Compare = (int num) => num > 15;

Expression<Func<int, bool>> Compare_Expression = (int num) => num > 15;
var Compare_Method = Compare_Expression.Compile();


