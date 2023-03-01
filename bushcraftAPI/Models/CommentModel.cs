namespace bushcraftAPI.Models{
    
    /// <summary name="CommentModel"> 
    /// This class contains the properties of a comment.
    /// </summary>
    public class CommentModel : BaseEntityModel{

        public string CommentContent { get; set; } = null!;
        public string CommentBy { get; set; } = null!;
        public CommentModel? ParentComment { get; set; } = null!;
        public PostModel? PostParent { get; set; } = null!;
        public UserModel User { get; set; } = null!;
        
        /// <summary name="PostComment">
        /// This will be a list of comments that are related to the post.
        /// </summary>
        public List<PostCommentModel> PostComments { get; set; } = new List<PostCommentModel>();
        
        /// <summary name="ChildComments">
        /// This will be a list of comments that are related to the post.
        /// </summary>
        public List<CommentModel> ChildComments { get; set; } = new List<CommentModel>();
       
        /// <summary name="UserModelList">
        /// This list contains all the comments from the user.
        /// </summary>
        public List<UserModel> UserList = new List<UserModel>();
    }
}