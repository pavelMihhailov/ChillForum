namespace ChillForum.Profiles.Models.Profile
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static ChillForum.Profiles.Data.DataConstants;

    public class CreateProfileInputModel
    {
        public string UserId { get; set; }

        [Required]
        [MinLength(MinUsernameLength)]
        [MaxLength(MaxUsernameLength)]
        public string Username { get; set; }

        [MaxLength(MaxProfileDescriptionLength)]
        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
