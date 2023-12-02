using MediatR;
using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;

namespace WithIn.Application.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
{
    private readonly IUnitOfWork _uow;

    public AddUserCommandHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        _uow.User.Add(new User { });
        _uow.User.Add(new User { });
        _uow.User.Add(new User { });
        
        return await _uow.SaveAsync();
    }
}