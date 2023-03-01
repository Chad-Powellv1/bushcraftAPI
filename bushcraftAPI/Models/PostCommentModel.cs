namespace bushcraftAPI.Models{
    
    /// <summary name="PostCommentModel"> 
    /// This model is used to create a relationship between posts and comments.
    /// </summary>
    public class PostCommentModel{
        public int Id { get; set; }
        public string PostModelId { get; set; } = null!;
        public PostModel PostContent { get; set; } = null!;
        public string CommentModelId { get; set; } = null!;
        public CommentModel CommentContent { get; set; } = null!;
    }
}