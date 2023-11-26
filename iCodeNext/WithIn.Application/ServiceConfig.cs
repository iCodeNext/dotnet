using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WithIn.Application;

public static class ServiceConfig
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services;
    }
}