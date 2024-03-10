using Microsoft.AspNetCore.Mvc;

namespace DependencyPrinciples.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class NumberController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(5);
    }
}
