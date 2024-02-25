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
                //services.Configure<HostOptions>(options =>
                //{
                //    options.ServicesStartConcurrently = true;
                //    options.ServicesStopConcurrently = true;
                //});
                services.AddHostedService<WorkerOne>();
                services.AddHostedService<WorkerTwo>();
                services.AddHostedService<WorkerThree>();
            }).Build();

        host.Run();
    }
}

public class WorkerOne : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerOne is Started!");
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
        Console.WriteLine("WorkerTwo is Started!");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerTwo is Stoped!");
    }
}


public class WorkerThree : IHostedLifecycleService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerTwo is StartAsync!");
    }

    public async Task StartedAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerTwo is StartedAsync!");
    }

    public async Task StartingAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerTwo is StartingAsync!");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("WorkerTwo is StopAsync!");
    }

    public async Task StoppedAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerTwo is StoppedAsync!");
    }

    public async Task StoppingAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine("WorkerTwo is StoppingAsync!");
    }
}




//public class Program
//{
//    static void Main()
//    {

//Policy.Handle<TimeoutException>().WaitAndRetry(new[]
//{
//    TimeSpan.FromSeconds(1),
//    TimeSpan.FromSeconds(2),
//    TimeSpan.FromSeconds(4),
//    TimeSpan.FromSeconds(8),
//    TimeSpan.FromSeconds(16)
//});


//var delay = Backoff.DecorrelatedJitterBackoffV2
//    (medianFirstRetryDelay: TimeSpan.FromSeconds(1),
//     retryCount: 5);

//Policy.Handle<TimeoutException>()
//      .WaitAndRetryAsync(delay);



//    }
//}

//[MemoryDiagnoser]
//public class FrozenBenchmark
//{
//    private const int Iterations = 1000;
//    private readonly List<int> list = Enumerable.Range(0, Iterations).ToList();
//    private readonly HashSet<int> hashSet = Enumerable.Range(0, Iterations).ToHashSet();
//    private readonly ImmutableHashSet<int> immutableHashSet = Enumerable.Range(0, Iterations).ToImmutableHashSet();
//    private readonly FrozenSet<int> frozenSet = Enumerable.Range(0, 1000).ToFrozenSet();

//    [Benchmark]
//    public void LookupFrozen()
//    {
//        for (var i = 0; i < Iterations; i++)
//            _ = frozenSet.Contains(i);
//    }


//    [Benchmark(Baseline = true)]
//    public void LookupList()
//    {
//        for (var i = 0; i < Iterations; i++)
//            _ = list.Contains(i);
//    }



//    [Benchmark]
//    public void LookupHashSet()
//    {
//        for (var i = 0; i < Iterations; i++)
//            _ = hashSet.Contains(i);
//    }

//    [Benchmark]
//    public void LookupImmutableHashSet()
//    {
//        for (var i = 0; i < Iterations; i++)
//            _ = immutableHashSet.Contains(i);
//    }
//}

//[MemoryDiagnoser]
//public class FrozenBenchmark
//{
//    private readonly int[] from = Enumerable.Range(0, 1000).ToArray();

//    [Benchmark(Baseline = true)]
//    public List<int> CreateList() => from.ToList();

//    [Benchmark]
//    public FrozenSet<int> CreateFrozenList()
//    {
//        int[] from = Enumerable.Range(0, 1000).ToArray();
//        return from.ToFrozenSet();
//    }

//    [Benchmark]
//    public HashSet<int> CreateHashSet() => from.ToHashSet();

//    [Benchmark]
//    public ImmutableHashSet<int> CreateImmutableHashSet() => from.ToImmutableHashSet();
//}