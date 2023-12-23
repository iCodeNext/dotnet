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


    app.MapGet("/users/{userId:int}", (int userId) => { });
    app.MapGet("/posts/{**slug:regex(^[a-z0-9]+$)}", (string slug) => { });
    app.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{Id?}");




    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}