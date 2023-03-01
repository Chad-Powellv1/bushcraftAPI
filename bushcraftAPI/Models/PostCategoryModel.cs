
namespace bushcraftAPI.Models{
    /// <summary name="PostCategoryModel"> 
    /// This model used to create the relationship between posts and categories.
    /// </summary>
    public class PostCategoryModel{
        public int Id { get; set; }
        public string PostModelId { get; set; } = null!;
        public PostModel PostContent { get; set; } = null!;
        public string CategoryModelId { get; set; } = null!;
        public CategoryModel CategoryContent { get; set; } = null!;
    }
}