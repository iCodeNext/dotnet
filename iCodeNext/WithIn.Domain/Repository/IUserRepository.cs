using WithIn.Domain.Entities;

namespace WithIn.Domain.Repository;

public interface IUserRepository
{
    Task<int> Add(User user);
}


