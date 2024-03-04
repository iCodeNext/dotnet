using MediatR;
using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;

namespace WithIn.Application.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
{
    private readonly IUnitOfWork _uow;
    private readonly IUserRepository _userRepository;
    public AddUserCommandHandler(IUnitOfWork uow, IUserRepository userRepository)
    {
        _uow = uow;
        _userRepository = userRepository;
    }

    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        _userRepository.Add(new User() { });

        //
        //

        await _uow.SaveAsync();
        return 0;
    }
}
