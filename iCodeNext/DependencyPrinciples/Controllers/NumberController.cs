using Microsoft.AspNetCore.Mvc;

namespace DependencyPrinciples.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class NumberController(INumberService numberService1, INumberService numberService2, INumberService numberService3) : Controller
{
    private readonly INumberService _numberService1 = numberService1;
    private readonly INumberService _numberService2 = numberService2;
    private readonly INumberService _numberService3 = numberService3;


    [HttpGet]
    public IActionResult Get()
    {
        return Ok($"{_numberService1.Generate()} , {_numberService2.Generate()} , {_numberService3.Generate()}");
    }
}
