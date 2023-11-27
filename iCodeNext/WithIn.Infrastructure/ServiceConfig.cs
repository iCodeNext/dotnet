using WithIn.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WithIn.Domain.Repositories;
using WithIn.Infrastructure.Repositories;

namespace WithIn.Infrastructure;

public static class ServiceConfig
{
    public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>((options) =>
        {
            options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"))
                   .LogTo(Console.WriteLine, LogLevel.Information);
        });

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }
}
