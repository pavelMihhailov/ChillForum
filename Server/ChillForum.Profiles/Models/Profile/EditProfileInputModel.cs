namespace ChillForum.Profiles.Models.Profile
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static ChillForum.Profiles.Data.DataConstants;

    public class EditProfileInputModel
    {
        [MaxLength(MaxProfileDescriptionLength)]
        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
