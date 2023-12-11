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
}