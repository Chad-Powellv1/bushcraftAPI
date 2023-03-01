namespace bushcraftAPI.Models{
    /// <summary name="PostTagModel"> 
    /// This model is used to create the relationship between posts and tags.
    /// </summary>
    public class PostTagModel{
        public int Id { get; set; }
        public string PostModelId { get; set; } = null!;
        public PostModel PostContent { get; set; } = null!;
        public string TagModelId { get; set; } = null!;
        public TagModel TagContent { get; set; } = null!;
    }
}