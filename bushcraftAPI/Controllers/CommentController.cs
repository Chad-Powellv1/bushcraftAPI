using bushcraftAPI.Models;
using bushcraftAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bushcraftAPI.Controllers{
    /// <summary name="CommentController">
    /// This Controller is used to define the CRUD operations for the CommentModel,
    /// and returns the appropriate data to the client via the API view.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase{
        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<CommentModel> GetAllComments()
        {
            return _commentRepository.GetAllComments();
        }

        [HttpGet("Get/{id}")]
        public CommentModel GetComment(int id)
        {
            return _commentRepository.GetComment(id);
        }

        [HttpPost("AddComment")]
        public CommentModel AddComment([FromBody] CommentModel commentModel)
        {
            return _commentRepository.AddComment(commentModel);
        }

        [HttpPut("UpdateComment")]
        public CommentModel UpdateComment([FromBody] CommentModel commentModel)
        {
            return _commentRepository.UpdateComment(commentModel);
        }

        [HttpDelete("DeleteComment/{id}")]
        public CommentModel DeleteComment(int id)
        {
            return _commentRepository.DeleteComment(id);
        }
    }
}