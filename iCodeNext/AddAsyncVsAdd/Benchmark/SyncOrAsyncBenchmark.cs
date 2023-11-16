using AddAsyncVsAdd.Context;
using AddAsyncVsAdd.Domain;
using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AddAsyncVsAdd.Benchmark;

[MemoryDiagnoser]
public class SyncOrAsyncBenchmark
{
    [Benchmark]
    public async Task SyncScenario()
    {
        var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                        .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
                        .Options;

        ApplicationDbContext dbContext = new(dbContextOptions);

        dbContext.Customers.Add(new Customer
        {
            FirstName = "Mohammad",
            LastName = "Karimi"
        });

        await dbContext.SaveChangesAsync();
    }

    [Benchmark]
    public async Task ASyncScenario()
    {
        var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                        .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
                        .Options;

        ApplicationDbContext dbContext = new(dbContextOptions);

        await dbContext.Customers.AddAsync(new Customer
        {
            FirstName = "Mohammad",
            LastName = "Karimi"
        });

        await dbContext.SaveChangesAsync();
    }
}
