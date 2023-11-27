using WithIn.Domain.Entities;

namespace WithIn.Domain.Repository;

public interface IUserRepository
{
    void Add(User user);
    Task<int> SaveAsync();
}
