using bushcraftAPI.Context;
using bushcraftAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Interface{
    /// <summary name="TagInterface">
    /// This interface connects to the database and allows the user to
    /// Create, Read, Update, and Delete posts from the database, with
    /// methods that are defined in the ITagRepository.
    /// </summary>
    public class TagInterface{
        private readonly BlogContext _blogContext;

        public TagInterface(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public TagModel? AddTag(TagModel? tagModel)
        {
            _blogContext.Tags.Add(tagModel);
            _blogContext.SaveChanges();
            return tagModel;
        }

        public TagModel? DeleteTag(int id)
        {
            TagModel? tagModel = _blogContext.Tags.Find(id);
            if (tagModel != null)
            {
                _blogContext.Tags.Remove(tagModel);
                _blogContext.SaveChanges();
            }

            return tagModel;
        }

        public TagModel? GetTag(int id)
        {
            return _blogContext.Tags.Find(id);
        }

        public IEnumerable<TagModel?> GetAllTags()
        {
            return _blogContext.Tags;
        }

        public TagModel? UpdateTag(TagModel? tagModel)
        {
            var tag = _blogContext.Tags.Attach(tagModel);
            tag.State = EntityState.Modified;
            return tagModel;
        }
    }
}