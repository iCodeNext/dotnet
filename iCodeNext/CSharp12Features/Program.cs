
public class Complain
{
    public int MyProperty { get; set; }
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; set; }
}

public class ComplainSubClass : Complain
{
    public int MyProperty3 { get; set; }
}

public class Program
{

    public static void Main(string[] args)
    {
        ComplainSubClass ins_1 = new ComplainSubClass();
        Complain complain = ins_1;

        ComplainSubClass ins_2 = (ComplainSubClass)complain;
    }
}
