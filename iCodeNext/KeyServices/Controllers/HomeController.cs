using Microsoft.AspNetCore.Mvc;

namespace KeyServices.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController([FromKeyedServices(nameof(SmsService))] IEventService eventService) : ControllerBase
{
    [HttpGet]
    public ActionResult Index()
    {
        eventService.Send("new message");
        return Ok("OK From Index!");
    }
}

public interface IEventService
{
    void Send(string message);
}

public class SmsService : IEventService
{
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}

public class EmailService : IEventService
{
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}