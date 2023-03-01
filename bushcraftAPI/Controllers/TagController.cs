using bushcraftAPI.Models;
using bushcraftAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bushcraftAPI.Controllers{
    /// <summary name="TagController">
    /// This Controller is used to define the CRUD operations for the TagModel,
    /// and returns the appropriate data to the client via the API view.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : ControllerBase{
        public readonly ITagRepository _tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<TagModel> GetAllTags()
        {
            return _tagRepository.GetAllTags();
        }

        [HttpGet("Get/{id}")]
        public TagModel GetTag(int id)
        {
            return _tagRepository.GetTag(id);
        }

        [HttpPost("AddTag")]
        public TagModel AddTag([FromBody] TagModel tagModel)
        {
            return _tagRepository.AddTag(tagModel);
        }

        [HttpPut("UpdateTag")]
        public TagModel UpdateTag([FromBody] TagModel tagModel)
        {
            return _tagRepository.UpdateTag(tagModel);
        }

        [HttpDelete("DeleteTag/{id}")]
        public TagModel DeleteTag(int id)
        {
            return _tagRepository.DeleteTag(id);
        }
    }
}