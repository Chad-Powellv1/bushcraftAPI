using bushcraftAPI.Models;

namespace bushcraftAPI.Repository{
    /// <summary name="ICommentRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete comments.
    /// </summary>
    public interface ICommentRepository{
        CommentModel GetComment(int id);
        IEnumerable<CommentModel> GetAllComments();
        CommentModel AddComment(CommentModel commentModel);
        CommentModel UpdateComment(CommentModel commentModel);
        CommentModel DeleteComment(int id);
    }
}