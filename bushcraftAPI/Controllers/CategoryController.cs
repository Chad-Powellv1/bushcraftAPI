using bushcraftAPI.Models;
using bushcraftAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bushcraftAPI.Controllers{
    /// <summary name="CategoryController">
    /// This Controller is used to define the CRUD operations for the CategoryModel,
    /// and returns the appropriate data to the client via the API view.
    /// </summary>
    public class CategoryController : ControllerBase{
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        [HttpGet("Get/{id}")]
        public CategoryModel GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }

        [HttpPost("AddCategory")]
        public CategoryModel AddCategory([FromBody] CategoryModel categoryModel)
        {
            return _categoryRepository.AddCategory(categoryModel);
        }

        [HttpPut("UpdateCategory")]
        public CategoryModel UpdateCategory([FromBody] CategoryModel categoryModel)
        {
            return _categoryRepository.UpdateCategory(categoryModel);
        }

        [HttpDelete("DeleteCategory/{id}")]
        public CategoryModel DeleteCategory(int id)
        {
            return _categoryRepository.DeleteCategory(id);
        }
    }
}