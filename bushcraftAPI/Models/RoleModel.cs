using Microsoft.AspNetCore.Identity;

namespace bushcraftAPI.Models{
    /// <summary name="RoleModel">
    /// This class is used to create a user role for the application.
    /// </summary>
    public class RoleModel : IdentityRole{
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    }
}