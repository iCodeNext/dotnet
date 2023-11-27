using MediatR;
using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;

namespace WithIn.Application.Users.Commands.AddUser;

public class AddUserCommandHandler(IGenericRepository<User> userRepository)
    : IRequestHandler<AddUserCommand, int>
{
    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
 
        userRepository.Add(new User { });
        return await userRepository.SaveAsync();
    }
}
