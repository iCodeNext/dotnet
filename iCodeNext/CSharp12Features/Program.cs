public class Program
{
    public static void Main(string[] args)
    {
        var lambda = (int x) => { return x * 8; };
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public static class PersonExtension
{
    public static void Run(this Person person)
    {
        Console.WriteLine("Run");
    }
}


 