using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace GenericConstraint;

public class Program
{
    static void Main()
    {
        //int capacity = 100_000;
        //List<int> list = [];
        //for (int i = 0; i < capacity; i++)
        //    list.Add(i);

        //list.Contains(15212);
        //var imutable_1 = list.ToImmutableList();
        //imutable_1.Add(6556);

        //var frozen = list.ToFrozenSet();
        //frozen.Contains(6556);
        
        BenchmarkRunner.Run<FrozenBenchmark>();
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

[MemoryDiagnoser]
public class FrozenBenchmark
{
    private readonly int[] from = Enumerable.Range(0, 1000).ToArray();

    [Benchmark(Baseline = true)]
    public List<int> CreateList() => from.ToList();

    [Benchmark]
    public FrozenSet<int> CreateFrozenList()
    {
        int[] from = Enumerable.Range(0, 1000).ToArray();
        return from.ToFrozenSet();
    }

    [Benchmark]
    public HashSet<int> CreateHashSet() => from.ToHashSet();

    [Benchmark]
    public ImmutableHashSet<int> CreateImmutableHashSet() => from.ToImmutableHashSet();
}