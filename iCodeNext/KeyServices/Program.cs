
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}

public class FileBackgroundService : IHostedLifecycleService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}