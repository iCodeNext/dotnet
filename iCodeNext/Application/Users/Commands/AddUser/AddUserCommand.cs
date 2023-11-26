using MediatR;

namespace Application.Users.Commands.AddUser;

public record AddUserCommand(string Name, string Email, string MobileNumber)
    : IRequest<int>;