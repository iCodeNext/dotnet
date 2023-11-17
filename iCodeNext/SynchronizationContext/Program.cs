namespace SynchronizationContext;
public class Program
{
    public static async Task Main(string[] args)
     => await MethodA();

    public static async Task MethodA()
    {
        await MethodB();
        Console.WriteLine("Method B");
    }

    public static async Task MethodB()
    {
        await Task.Delay(1000);
        Console.WriteLine("Method C");
    }
}