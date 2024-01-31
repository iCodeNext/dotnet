// See https://aka.ms/new-console-template for more information
using Refit;
using Refit_Toturial;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
IServiceCollection services = default;

string baseAddress = "https://api.example.com";
services.AddRefitClient<IApiClient>()
        .ConfigureHttpClient(c =>
        c.BaseAddress = new Uri(baseAddress));

var _apiClient = RestService.For<IApiClient>(baseAddress);

var posts = await _apiClient.GetPosts();


    public class PostsController(IApiClient apiClient)
        : ControllerBase
    {
        private readonly IApiClient _apiClient = apiClient;
    
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _apiClient.GetPosts();
            return Ok(posts);
        }
}


 