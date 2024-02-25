using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Polly;
using Polly.Contrib.WaitAndRetry;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace GenericConstraint;

public class Program
{
    static void Main()
    {

        Policy.Handle<TimeoutException>().WaitAndRetry(new[]
        {
            TimeSpan.FromSeconds(1),
            TimeSpan.FromSeconds(2),
            TimeSpan.FromSeconds(4),
            TimeSpan.FromSeconds(8),
            TimeSpan.FromSeconds(16)
        });


        var delay = Backoff.DecorrelatedJitterBackoffV2
            (medianFirstRetryDelay: TimeSpan.FromSeconds(1),
             retryCount: 5);

        Policy.Handle<TimeoutException>()
              .WaitAndRetryAsync(delay);



    }
}

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