namespace a;
#nullable disable


    public record Person_Record(string Name,string Family);
    
    public class Person_Class
    {
        public string Name { get; set; }
    }

public class Program
{
    public static void Main(string[] args)
    {
        var p1 = new Person_Record("Mohammad","Karimi");
        var p2 = new Person_Record("Mohammad", "Karimi");
         
        Console.WriteLine(p1.Equals(p2)); // true

        var p3 = new Person_Class() { Name = "Mohammad" };
        var p4 = new Person_Class() { Name = "Mohammad" };

        Console.WriteLine(p3.Equals(p4)); // False
    }
}





