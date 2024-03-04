using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext dbContext)
{
    protected readonly ApplicationDbContext _dbContext = dbContext;
    public void Add(User entity)
    {
        _dbContext.User.Add(entity);
    }
}
