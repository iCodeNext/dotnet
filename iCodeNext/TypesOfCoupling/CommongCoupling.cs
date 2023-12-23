namespace TypesOfCoupling;


file class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

file class UserService
{
    public void InsertUser(User user)
    {
        GlobalData.SequenceId += 1;
        //TODO
    }
}

public class GlobalData
{
    public static int SequenceId = 0;
}

file class OrderService
{
    public void AddOrder()
    {
        GlobalData.SequenceId += 1;
        //TODO
    }
}
