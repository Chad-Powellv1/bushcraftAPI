using System.ComponentModel.DataAnnotations;

namespace bushcraftAPI.Models{
    /// <summary name="LoginViewModel">
    /// This class is used to define the properties for the login view model.
    /// </summary>
    public class LoginViewModel{
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember me?")] public bool RememberMe { get; set; }
    }
}