namespace CSharp12Features.PrimaryConstructor;

//public class Order_Compiled
//{
//    private int _sadlfkjlw453l45jl345_id;
//    public Order_Compiled(int id)
//    {
//        _sadlfkjlw453l45jl345_id = id;
//    }

//    public string ToString()
//    {
//        return _sadlfkjlw453l45jl345_id.ToString();
//    }
//}

//public class Order(int id)
//{
//    public Order() : this(15)
//    {
//    }

//    public string ToString()
//    {
//        return id.ToString();
//    }
//}


public class Entity(int id)
{
    public override string ToString()
       => id.ToString();
}

public class Order(int id) : Entity(id)
{
    public override string ToString()
        => id.ToString();
}

public class UserService(IServiceProvider serviceProvider)
{
}

//public class Order(int id, int code)
//{
//    public string ToString()
//    {
//        return id.ToString();
//    }
//}

public class Order_Compiled
{
    private int _sadlfkjlw453l45jl345_id;
    public Order_Compiled(int id, int code)
    {
        _sadlfkjlw453l45jl345_id = id;
    }

    public string ToString()
    {
        return _sadlfkjlw453l45jl345_id.ToString();
    }
}
