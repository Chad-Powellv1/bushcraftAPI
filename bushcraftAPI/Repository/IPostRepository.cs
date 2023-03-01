using bushcraftAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Repository{
    
    /// <summary name="IPostRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete posts.
    /// </summary>
    public interface IPostRepository{
        PostModel? GetPost(int id);
        IEnumerable<PostModel> GetAllPosts();
        PostModel AddPost(PostModel postModel);
        PostModel UpdatePost(PostModel postModel);
        PostModel? DeletePost(int id);
    }
}