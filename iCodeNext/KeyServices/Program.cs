using KeyServices.Controllers;
using KeyServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddKeyedScoped<IEventService, SmsService>(nameof(SmsService));
    builder.Services.AddKeyedScoped<IEventService, EmailService>("EMAIL");
}

var app = builder.Build();
{


    app.MapGet("/", () => "No short-circuiting!");
    app.MapHealthChecks("/healthz").ShortCircuit();
    app.MapShortCircuit(404, "robots.txt", "favicon.ico");
    




    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}