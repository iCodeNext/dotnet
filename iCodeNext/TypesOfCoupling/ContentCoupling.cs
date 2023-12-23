namespace TypesOfCoupling;



file class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

file class UserService
{
    public IReadOnlyList<User> GetUsers()
    {
        var result = new List<User>();

        // result = DbContext.Users.Where(x=> x.Name == "Mohammad").ToList();

        return result;
    }
}


file class GiftGenerator(UserService userService)
{
    private readonly UserService _userService = userService;

    public void Generate()
    {
        var users = _userService.GetUsers();
        foreach (var user in users)
        {
            //Create Discount Code
        }
    }
}