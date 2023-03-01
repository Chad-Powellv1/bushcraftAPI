using bushcraftAPI.Context;
using bushcraftAPI.Models;
using bushcraftAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Interface{
    /// <summary name="ICategoryInterface">
    /// This interface is used to define the methods that are used to
    /// Create, Read, Update, and Delete categories from the database.
    /// </summary>
    public class CommentInterface{
        
        private readonly BlogContext _blogContext;
        
        public CommentInterface(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        
        public CommentModel? GetComment(int id)
        {
            return _blogContext.Comments.Find(id);
        }

        public IEnumerable<CommentModel> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public CommentModel AddComment(CommentModel commentModel)
        {
            throw new NotImplementedException();
        }

        public CommentModel UpdateComment(CommentModel commentModel)
        {
            throw new NotImplementedException();
        }
    }
}