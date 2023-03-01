using bushcraftAPI.Models;
using bushcraftAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bushcraftAPI.Controllers{
    /// <summary name="PostController">
    /// This Controller is used to define the CRUD operations for the PostModel,
    /// and returns the appropriate data to the client via the API view.
    /// </summary>
    
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase{
        
        private readonly IPostRepository _postRepository;
        
        public PostController(IPostRepository postRepository){
            _postRepository = postRepository;
        }
        
        [HttpGet("GetPosts")]
        public IEnumerable<PostModel> GetPosts(){
            return _postRepository.GetAllPosts();
        }
        
        [HttpGet("GetPost/{id}")]
        public PostModel? GetPost(int id){
            return _postRepository.GetPost(id);
        }
        
        [HttpPost("AddPost")]
        public PostModel AddPost([FromBody] PostModel postModel){
            return _postRepository.AddPost(postModel);
        }
        
        [HttpPut("UpdatePost")]
        public PostModel UpdatePost([FromBody] PostModel postModel){
            return _postRepository.UpdatePost(postModel);
        }
        
        [HttpDelete("DeletePost/{id}")]
        public PostModel? DeletePost(int id){
            return _postRepository.DeletePost(id);
        } 
    }
}