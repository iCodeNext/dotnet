namespace CSharp12Features.lambda;

public class Program
{
    public void Main(string[] args)
    {
        var action = (int x = 75) => {  };

        var action1 = (params string[] names) =>
        {

        };

        var action2 = (int number) => {   };
 
    }

    public delegate int ProcessMethod(int number);
}