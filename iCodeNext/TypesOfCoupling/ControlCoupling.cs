namespace TypesOfCoupling;

file class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
file class UserService
{
    public void InsertOrUpdateUser(User user, bool isAdd)
    {
        if (isAdd)
        {
            // add into database
        }
        else
        {
            // update database
        }
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
        _userService.InsertOrUpdateUser(model, true);
    }
}
