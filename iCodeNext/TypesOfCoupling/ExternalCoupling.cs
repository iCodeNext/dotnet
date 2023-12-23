namespace TypesOfCoupling;

file class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

file class UserService
{
    #region CTOR
    //private readonly IHttpClient _httpClient;
    //public UserService(IHttpClient httpClient)
    //{
    //    _httpClient = httpClient
    //} 
    #endregion
    public void InsertUser(User user)
    {

        HttpClient httpClient = new HttpClient();
       // httpClient.Send(user);

        //httpClient.Send();
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
    }
}


file interface IHttpClient
{
    void Send(object obj);
}