using WithIn.Domain.Entities;
using WithIn.Domain.Repository;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public void Add(User user)
    {
        dbContext.User.Add(user);
    }

    public async Task<int> SaveAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}
