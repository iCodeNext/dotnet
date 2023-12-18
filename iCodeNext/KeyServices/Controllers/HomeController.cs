using KeyServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyServices.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController(
    [FromKeyedServices(nameof(SmsService))] IEventService eventService)
    : ControllerBase
{
    private readonly IEventService _eventService = eventService;

    [HttpGet]
    public ActionResult Index()
    {
        _eventService.Push("message");
        return Ok("OK From Index!");
    }



    [HttpGet("/fire-and-forget-1")]
    public IActionResult BadFireAndForget()
    {
        _ = Task.Run(async () =>
        {
            await Task.Delay(1000);
            Log(HttpContext.Request.Path);
        });
        return Accepted();
    }


    [HttpGet("/fire-and-forget-3")]
    public IActionResult GoodFireAndForget()
    {
        string path = HttpContext.Request.Path;
        _ = Task.Run(async () =>
        {
            await Task.Delay(1000);
            Log(path);
        });
        return Accepted();
    }



    private void Log(PathString path)
    {
        throw new NotImplementedException();
    }
}