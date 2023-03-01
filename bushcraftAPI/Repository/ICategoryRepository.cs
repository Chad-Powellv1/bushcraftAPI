using bushcraftAPI.Models;

namespace bushcraftAPI.Repository{
    /// <summary name="ICategoryRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete categories.
    /// </summary>
    public interface ICategoryRepository{
        public CategoryModel GetCategory(int id);
        public IEnumerable<CategoryModel> GetAllCategories();
        public CategoryModel AddCategory(CategoryModel categoryModel);
        public CategoryModel UpdateCategory(CategoryModel categoryModel);
        public CategoryModel DeleteCategory(int id);
    }
}