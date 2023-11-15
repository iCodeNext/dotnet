using Microsoft.EntityFrameworkCore;

namespace ChangingConnectionString.Context;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options,
        IGetConnection getConnection) : base(options)
             => Database.SetConnectionString(getConnection?.CurrentConnection());
}

public interface IGetConnection
{
    string CurrentConnection();
}
