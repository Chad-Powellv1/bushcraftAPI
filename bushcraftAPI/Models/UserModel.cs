using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bushcraftAPI.Models{
    /// <summary name="UserModel">
    /// This class is used to represent a user in the database.
    /// </summary>
    public class UserModel : IdentityUser{
        
        [Required, MaxLength(50, ErrorMessage = "First Name is required")]
        public string FirstName { get; set; } = string.Empty;
        [Required, MaxLength(50, ErrorMessage = "Last Name is required")]
        public string LastName { get; set; } = string.Empty;

        
        public List<RoleModel> Roles { get; set; } = new List<RoleModel>();
        public List<PostModel> Posts { get; set; } = new List<PostModel>();
        public List<CommentModel> Comments { get; set; } = new List<CommentModel>();
        
    }
}