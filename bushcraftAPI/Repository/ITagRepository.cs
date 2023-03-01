using bushcraftAPI.Models;

namespace bushcraftAPI.Repository{
    /// <summary name="ITagRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete tags.
    /// </summary>
    public interface ITagRepository{
        TagModel GetTag(int id);
        IEnumerable<TagModel> GetAllTags();
        TagModel AddTag(TagModel tagModel);
        TagModel UpdateTag(TagModel tagModel);
        TagModel DeleteTag(int id);
    }
}