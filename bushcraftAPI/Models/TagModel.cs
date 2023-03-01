namespace bushcraftAPI.Models{
    
    /// <summary name="TagModel"> 
    /// This model contains the properties of a tag.
    /// </summary>
    public class TagModel : BaseEntityModel{
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Slug { get; set; } = null!;

        /// <summary name="PostTags">
        /// This list contains all the posts that have this tag.
        /// </summary>
        public List<PostTagModel> PostTags { get; set; } = new List<PostTagModel>();

    }
}