using WithIn.Domain.Repositories;

namespace WithIn.Application.Common.Interfaces;

public interface IUnitOfWork
{
   
    //public IUserRepository UserRepository { get; }
    //public IOrderRepository OrderRepository { get; }

    Task<int> SaveAsync();
}

//Context per request -> Scoped
