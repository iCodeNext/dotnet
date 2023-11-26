using KeyServices.Controllers;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddKeyedScoped<IEventService, SmsService>(nameof(SmsService));
    builder.Services.AddKeyedScoped<IEventService, EmailService>(nameof(EmailService));
}

var app = builder.Build();
{
 
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}