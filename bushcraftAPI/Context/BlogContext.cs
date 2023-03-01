using bushcraftAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Context{
    /// <summary name="AppContext">
    /// This class is used to create the database context for the application.
    /// </summary>
    public class BlogContext : DbContext{
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<TagModel> Tags { get; set; }
        public DbSet<PostTagModel> PostTags { get; set; }
        public DbSet<PostCategoryModel> PostCategories { get; set; }
        public DbSet<PostCommentModel> PostComments { get; set; }
    }
}