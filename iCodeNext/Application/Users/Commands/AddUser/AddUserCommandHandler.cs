using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Users.Commands.AddUser;

public class AddUserCommandHandler(IApplicationDbContext dbContext) : IRequestHandler<AddUserCommand, int>
{
    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        dbContext.User.Add(new User { });
        return await dbContext.SaveChangesAsync();
    }
}
