using System.Collections.Immutable;

namespace CSharp12Features.CollectionExpression;

public class CollectionExpressionExamples
{
    public void Test()
    {
        int[] ints = { 1, 2, 3 };
        int[] ints2 = new int[] { 1, 2, 3 };
        int[] ints3 = new[] { 1, 2, 3 };

        Span<int> span = new Span<int>(new[] { 1, 2, 3 });
        Span<int> span2 = stackalloc[] { 1, 2, 3 };
        ReadOnlySpan<int> span3 = stackalloc[] { 1, 2, 3 };

        List<int> list = new() { 1, 2, 3 };

        ImmutableArray<int> immutableArray = ImmutableArray.Create(new[] { 1, 2, 3 });

        int[] days = new int[] { 1, 2, 3 };
        foreach (var day in days)
        {
            Console.WriteLine(day);
        }

        Calculator calculator = new();
        calculator.Sum(new int[] { 1, 2, 3 });


        string hydrogen = "H";
        string helium = "He";

        string[] elements = new string[] { hydrogen, helium };

        string[] vowels = new string[] { "a", "e", "i", "o", "u" };
        string[] consonants = { "b", "c", "d", "z" };
       // string[] alphabet = new string[] { vowels, consonants };

        //int x = 2;
        //int y = 5;
        //bool z = false;

        //List<int> f = z ? [1, 2, 3] : [];
        //List<int> final = [x, y, .. f];


        //var array = new int[] { 1, 2, 3, 4, 5 };
        //var slice1 = array[2..^3];
        //var slice2 = array[..^3];
        //var slice3 = array[2..];
        //var slice4 = array[..];

        // MyCollection strings = ["asdf", "sdf"];

    }
}

public class Calculator
{
    public int[] Numbers
        => new int[] { 1, 2, 3 };

    public int Sum(IEnumerable<int> nums)
     => nums.Sum();

    //public List<string> GetAll()
    //{
    //    IReadOnlyList<string> lst = ["", ""];

    //    return ["asdfasddf", "asdfds", "sdfdf"];
    //}
}