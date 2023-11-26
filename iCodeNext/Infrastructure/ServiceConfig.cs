using Application.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Infrastructure;

public static class ServiceConfig
{
    public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>((options) =>
        {
            options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"))
                   .LogTo(Console.WriteLine, LogLevel.Information);
        });
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

        return services;
    }
}
