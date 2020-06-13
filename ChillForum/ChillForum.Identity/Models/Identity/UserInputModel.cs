namespace ChillForum.Identity.Models.Identity
{
    using System.ComponentModel.DataAnnotations;

    using static ChillForum.Identity.Data.IdentityConstants;

    public class UserInputModel
    {
        [EmailAddress]
        [Required]
        [MinLength(MinEmailLength)]
        [MaxLength(MaxEmailLength)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
