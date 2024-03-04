using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericConstraint;

public class Program
{
    public static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.Configure<HostOptions>(options =>
                {
                    options.ServicesStartConcurrently = true;
                    options.ServicesStopConcurrently = true;
                });
                services.AddHostedService<WorkerOne>();
                services.AddHostedService<WorkerTwo>();
                services.AddHostedService<WorkerThree>();
                services.AddHostedService<WorkerFour>();
            }).Build();

        host.Run();
    }
}

public class WorkerOne : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine($"WorkerOne is Started! {DateTime.Now}");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerOne is Stoped!");
    }
}

public class WorkerTwo : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine($"WorkerTwo is Started! {DateTime.Now}");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerTwo is Stoped!");
    }
}

public class WorkerThree : IHostedLifecycleService
{
    public async Task StartingAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(15000, cancellationToken);
        Console.WriteLine($"WorkerThree is StartingAsync! {DateTime.Now}");
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine($"WorkerThree is StartAsync! {DateTime.Now}");
    }

    public async Task StartedAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine($"WorkerThree is StartedAsync! {DateTime.Now}");
    }

    public async Task StoppingAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerThree is StoppingAsync!");
    }
    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerThree is StopAsync!");
    }

    public async Task StoppedAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerThree is StoppedAsync!");
    }

}


public class WorkerFour : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(1000, stoppingToken);
            Console.WriteLine("WorkerFour is ExecuteAsync!");
        }
    }
}
