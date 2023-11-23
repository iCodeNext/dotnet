using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharp12Features.lambda;

public class DefaultLambda
{

}

public class Program
{
    public void Main(string[] args)
    {
        Action<string[]> a3 = (params string[] s) => { };

        var IncrementBy = (int source, int increment = 1) => source + increment;
        IncrementBy(5);

         
        var Log = (string message, string path = "...")
            => File.WriteAllText(path, message);

        Log("Message");
        Log("Message", "Destination Path");


        var Sum = (params int[] scores)
            => {/* TODO */};

        Sum([15, 2, 15, 32, 88]);


    }
}
