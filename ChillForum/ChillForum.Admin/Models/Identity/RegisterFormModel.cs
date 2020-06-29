namespace ChillForum.Admin.Models.Identity
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterFormModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
