using System.ComponentModel.DataAnnotations;

namespace bushcraftAPI.Models{
    /// <summary name="RegisterViewModel">
    /// This class is used to represent the data that is sent to the server when a user registers.
    /// </summary>
    public class RegisterViewModel{
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}