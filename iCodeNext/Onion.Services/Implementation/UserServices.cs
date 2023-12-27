using Onion.Domain.Entities;
using Onion.Domain.Services;
using Onion.Services.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Services.Implementation;
public class UserServices : IUserServices
{
    private readonly IApplicationDbContext _dbContext;

    public UserServices(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Delete(User user)
    {
        _dbContext.Users.Remove(user);
    }

    public User FindById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(User user)
    {
        _dbContext.Users.Add(user);
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }
}
