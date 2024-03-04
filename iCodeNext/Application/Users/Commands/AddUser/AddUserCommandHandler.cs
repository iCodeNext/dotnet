using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Commands.AddUser;

public class AddUserCommandHandler(IApplicationDbContext dbContext) : IRequestHandler<AddUserCommand, int>
{
    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        dbContext.User.Add(new User { });
        var result = dbContext.User.Where(x => x.Id == 1)
            .AsNoTracking()
            .OrderBy(x => x.Name).ToList();

        var user = dbContext.User.FirstOrDefault(x => x.Id == 1);
        dbContext.User.Remove(user);

        return await dbContext.SaveChangesAsync();
    }
}
