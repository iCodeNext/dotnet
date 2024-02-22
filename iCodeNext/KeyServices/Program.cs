using KeyServices.Controllers;
using KeyServices.Interfaces;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddMassTransit((context, config) => { 
    
     
    });
}

var app = builder.Build();
{




    app.MapGet("/", (IBus bus) =>
    {
        bus.Publish(new Message() { IpAddress = "x" });
    });



    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}

public class Message
{
    public string IpAddress { get; set; }
}

public class Consumer : IConsumer<Message>
{
    public Task Consume(ConsumeContext<Message> context)
    {
        throw new NotImplementedException();
    }
}