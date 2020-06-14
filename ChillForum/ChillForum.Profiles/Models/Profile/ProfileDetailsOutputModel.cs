namespace ChillForum.Profiles.Models.Profile
{
    using System;

    public class ProfileDetailsOutputModel : ProfileOutputModel
    {
        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
