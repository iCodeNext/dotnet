using MediatR;
using WithIn.Application.Common.Interfaces;
using WithIn.Domain.Entities;
using WithIn.Domain.Repositories;

namespace WithIn.Application.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
{
    private readonly IUnitOfWork _uow;
    private readonly IUserRepository _userRepository;
    private readonly IOrderRepository _orderRepository;
    public AddUserCommandHandler(IUnitOfWork uow, IUserRepository userRepository, IOrderRepository orderRepository)
    {
        _uow = uow;
        _userRepository = userRepository;
        _orderRepository = orderRepository;
    }

    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        _userRepository.Add(new User { });
        _orderRepository.Delete();

        return await _uow.SaveAsync();
    }
}