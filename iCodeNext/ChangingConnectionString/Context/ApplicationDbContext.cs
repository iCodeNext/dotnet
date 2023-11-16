using Microsoft.EntityFrameworkCore;

namespace ChangingConnectionString.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IGetConnection getConnection) : base(options)
             => Database.SetConnectionString(getConnection?.CurrentConnection());
}

public interface IGetConnection
{
    string CurrentConnection();
}
