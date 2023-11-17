public class Program
{
    public static async Task Main(string[] args)
    {

        SynchronizationContext.SetSynchronizationContext(new MyContext());
        await MethodA();
        Console.WriteLine("Method A");
    }

    public static async Task MethodA()
    {
        await MethodB().ConfigureAwait(false);
        Console.WriteLine("Method B");
    }

    public static async Task MethodB()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        Console.WriteLine("Method C");
    }
}

public class MyContext : SynchronizationContext
{
    public override void Post(SendOrPostCallback d, object? state)
    {
        Console.WriteLine("MyContext!");
        base.Post(d, state);
    }
}