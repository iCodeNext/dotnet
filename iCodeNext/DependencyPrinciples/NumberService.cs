using DependencyPrinciples.Controllers;

namespace DependencyPrinciples;

public class NumberService : INumberService
{
    int _rndNumber = 0;

    public NumberService()
    {
        _rndNumber = Random.Shared.Next(15000);
    }

    public int Generate()
    {
        return _rndNumber;
    }
}
