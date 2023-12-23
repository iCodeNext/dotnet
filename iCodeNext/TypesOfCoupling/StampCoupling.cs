namespace TypesOfCoupling;

file class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Code { get; set; }
}
file class UserService
{
    public void InsertUser(User user)
    {
        //Do Something
    }

    public void UpdateUser(User user)
    {
        //Find User from db
        //chagne Name of User
        //Do Something
    }
}


file class UserController(UserService userService)
{
    private readonly UserService _userService = userService;

    public void Insert(string name, string email, string password)
    {
        var model = new User
        {
            Email = email,
            Name = name,
            Password = password
        };
        _userService.InsertUser(model);
        Log(model.Email,model.Name);
    }

    public void Log(string email,string name)
    {
        Console.WriteLine($"Log {email} {name}");
    }
}