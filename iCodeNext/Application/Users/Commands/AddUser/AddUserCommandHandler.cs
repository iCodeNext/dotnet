using Domain.Entities;
using MediatR;

namespace Application.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
{
    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {

    }
}
