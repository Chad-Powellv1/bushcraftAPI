using bushcraftAPI.Context;
using bushcraftAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Interface{
    /// <summary name="PostInterface">
    /// This interface connects to the database and allows the user to
    /// Create, Read, Update, and Delete posts from the database, with
    /// methods that are defined in the IPostRepository interface.
    /// </summary>
    public class PostInterface{
        
        private readonly BlogContext _blogContext;
        
        public PostInterface(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        
        public PostModel? AddPost(PostModel? postModel)
        {
            _blogContext.Posts.Add(postModel);
            _blogContext.SaveChanges();
            return postModel;
        }
        
        public PostModel? DeletePost(int id)
        {
            PostModel? postModel = _blogContext.Posts.Find(id);
            if (postModel != null)
            {
                _blogContext.Posts.Remove(postModel);
                _blogContext.SaveChanges();
            }
            
            return postModel;
        }
        
        public PostModel? GetPost(int id)
        {
            return _blogContext.Posts.Find(id);
        }
        
        public IEnumerable<PostModel?> GetAllPosts()
        {
            return _blogContext.Posts;
        }
        
        public PostModel? UpdatePost(PostModel? postModel)
        {
            var post = _blogContext.Posts.Attach(postModel);
            post.State = EntityState.Modified;
            return postModel;
        }
    }
}