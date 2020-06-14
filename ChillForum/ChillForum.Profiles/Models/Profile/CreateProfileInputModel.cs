namespace ChillForum.Profiles.Models.Profile
{
    using System;

    public class CreateProfileInputModel
    {
        public string UserId { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
