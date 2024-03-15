using DependencyPrinciples;
using DependencyPrinciples.Controllers;
using System;
using System.Reflection.PortableExecutable;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddTransient<INumberService, NumberService>();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
 