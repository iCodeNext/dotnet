using Refit;

namespace Refit_Toturial;

    public interface IApiClient
    {
        [Get("/api/posts")]
        Task<List<Post>> GetPosts();
    
        [Post("/api/posts")]
        Task<Post> CreatePost([Body] Post newPost);
    }


public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}