using Hexagonal.Application.Domain;
using Hexagonal.Application.Context;

namespace Hexagonal.Application.Services;

public class UserService
{
    private readonly IApplicationDbContext _dbContext;

    public UserService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Insert(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}
