namespace TypesOfCoupling;

file class UserService
{
    public void InsertUser(string name, string email, string password)
    {
        //Do Something
    }

    public void UpdateUser(string name, string email, string password)
    {
        //Do Something
    }
}


file class UserController(UserService userService)
{
    private readonly UserService _userService = userService;

    public void Insert(string name, string email, string password)
    {
        _userService.InsertUser(name, email, password);
    }
}