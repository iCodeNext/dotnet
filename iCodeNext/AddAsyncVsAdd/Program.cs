using AddAsyncVsAdd.Context;
using AddAsyncVsAdd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
    .LogTo(Console.WriteLine,LogLevel.Information)
    .EnableSensitiveDataLogging()
    .Options;

ApplicationDbContext dbContext = new(dbContextOptions);
await dbContext.Database.EnsureDeletedAsync();
await dbContext.Database.EnsureCreatedAsync();

dbContext.Customers.Add(new Customer
{
    FirstName = "Mohammad",
    LastName = "Karimi"
});

await dbContext.Customers.AddAsync(new Customer
{
    FirstName = "Alireza",
    LastName = "Mohammadi"
});


await dbContext.SaveChangesAsync();

