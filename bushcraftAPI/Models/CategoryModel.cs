namespace bushcraftAPI.Models{
    /// <summary name="Category Model">
    /// This class is used to represent a Post category,
    /// and holds the properties of a category.
    /// </summary>
    public class CategoryModel{
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Slug { get; set; } = null!;

        /// <summary name="AssociatedPosts">
        /// This property is used to hold the posts that are associated
        /// with a particular category.
        /// </summary>
        public List<PostModel> AssociatedPosts { get; set; } = new List<PostModel>();
    }
}