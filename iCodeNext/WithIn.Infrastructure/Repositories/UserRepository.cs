using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;
using WithIn.Infrastructure.Context;

namespace WithIn.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext dbContext)
    : GenericRepository<User>(dbContext), IUserRepository
{

}
