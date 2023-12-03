using KeyServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyServices.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController : ControllerBase
{
    private readonly IEventService _eventService;

    public HomeController([FromKeyedServices(nameof(SmsService))] IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpGet]
    public ActionResult Index()
    {
        //foreach (var item in _eventService)
        //{
        //    if (item is SmsService)
        //    {
        _eventService.Push("message");
        //}
        //}

        return Ok("OK From Index!");
    }
}