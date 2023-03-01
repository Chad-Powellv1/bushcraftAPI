namespace bushcraftAPI.Models{
    /// <summary name="PostModel">
    /// This is the model for the post, it contains the properties of the post.
    /// </summary>
    public class PostModel : BaseEntityModel{
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string PostContent { get; set; } = null!;
        public UserModel Author { get; set; } = null!;

        /// <summary name="PostTag">
        /// This will be a list of tags that are related to the post.
        /// </summary>
        public List<PostTagModel> PostTags { get; set; } = new List<PostTagModel>();

        /// <summary name="PostCategory">
        /// This will be a list of categories that are related to the post.
        /// </summary>
        public List<PostCategoryModel> PostCategories { get; set; } = new List<PostCategoryModel>();

        /// <summary name="PostComment">
        /// This will be a list of comments that are related to the post.
        /// </summary>
        public List<PostCommentModel> PostComments { get; set; } = new List<PostCommentModel>();

        /// <summary name="UserList">
        /// This list contains all the post from the user.
        /// </summary>
        public List<UserModel> AuthorList = new List<UserModel>();
    }
}