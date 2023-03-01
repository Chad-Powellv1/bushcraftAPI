using bushcraftAPI.Context;
using bushcraftAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace bushcraftAPI.Interface{
    /// <summary name="CategoryInterface">
    /// This interface connects to the database and allows the user to
    /// Create, Read, Update, and Delete posts from the database, with
    /// methods that are defined in the ICategoryRepository interface.
    /// </summary>
    public class CategoryInterface{
        private readonly BlogContext _blogContext;
        
        public CategoryInterface(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        
        public CategoryModel? AddCategory(CategoryModel? categoryModel)
        {
            _blogContext.Categories.Add(categoryModel);
            _blogContext.SaveChanges();
            return categoryModel;
        }
        
        public CategoryModel? DeleteCategory(int id)
        {
            CategoryModel? categoryModel = _blogContext.Categories.Find(id);
            if (categoryModel != null)
            {
                _blogContext.Categories.Remove(categoryModel);
                _blogContext.SaveChanges();
            }
            
            return categoryModel;
        }
        
        public CategoryModel? GetCategory(int id)
        {
            return _blogContext.Categories.Find(id);
        }
        
        public IEnumerable<CategoryModel?> GetAllCategories()
        {
            return _blogContext.Categories;
        }
        
        public CategoryModel? UpdateCategory(CategoryModel? categoryModel)
        {
            var category = _blogContext.Categories.Attach(categoryModel);
            category.State = EntityState.Modified;
            return categoryModel;
        }
        
    }
}